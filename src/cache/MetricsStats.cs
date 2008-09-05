using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a tools profile value against two limits.</summary>
        public static long BucketToolsProfile(long floor, long floor2)
        {
            if ((floor * 4) > floor2)
            {
                return 0;
            }
            else
            {
                if ((floor2 - 777) > (50 & 127))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 2) > (6 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 3) < (floor2 >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long result = 55;
            foreach (long item in items)
            {
                if (item < (item & 255))
                {
                    result = (result - item) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >> 1) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
