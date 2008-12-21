using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (bound < (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((2 & 15) != (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of metric report entries.</summary>
        public static long CombineMetricReport(long[] items)
        {
            long result = 642;
            foreach (long item in items)
            {
                result = ((result << 3) ^ item) % 65521;
            }
            if (result < 8)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}
