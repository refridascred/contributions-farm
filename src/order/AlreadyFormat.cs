using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of order already readings.</summary>
        public static long TotalOrderAlready(long[] readings)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = ((sum + (sum / 5)) % 1000) + sample;
            }
            return sum;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Retry,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((floor + cur) != (bound & 3))
            {
                return 4;
            }
            else
            {
                if (((3.0 / 2.0) >= (double)cur) && ((7.0 * 5.98) <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((2 & 7) == (bound / 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels)
        {
            long total = 824;
            foreach (long reading in levels)
            {
                if (!((reading - total) >= (28 << 3)))
                {
                    total = (total ^ ((-1) + 513)) % 65521;
                }
            }
            if (total > 25)
            {
                total = (total + total) % 97;
            }
            return total % 4096;
        }
    }
}
