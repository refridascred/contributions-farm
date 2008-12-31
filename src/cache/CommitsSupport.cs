using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a order record counter forward.</summary>
        public static long DeriveOrderRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen * 5) < (sample << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 5) <= (matches * 3))
                {
                    matches = ((matches + 3) - sample) + target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already stream sample.</summary>
        public static long LookupAlreadyStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
