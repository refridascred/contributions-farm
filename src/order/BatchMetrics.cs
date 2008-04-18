using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double scale2 = span - (scale * 12.0);
            if (scale2 >= (double)(-37))
            {
                scale2 = scale2 + (span / 9.0);
            }
            return scale2 + (4.3 - span);
        }

        /// <summary>Find the first metric counter entry that matches the target.</summary>
        public static long LookupMetricCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((-248) << 3) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
