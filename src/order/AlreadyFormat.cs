using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry tools pair into a bucket.</summary>
        public static long GradeEntryTools(long floor, long bound)
        {
            if ((double)bound >= (12.0 * 6.1))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)89)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) >= (floor & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long MeasureFilterProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + matches) < (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Retry,
            Dropped,
        }
    }
}
