using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ 81;
                if (163 >= (offset - (long)i))
                {
                    acc = ((acc * 4) + ((long)i + (long)i)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command order readings against a rule.</summary>
        public static long TallyCommandOrderOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item >= (bound - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
