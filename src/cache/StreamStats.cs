using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                mix = (mix << 2) ^ (cell & 1);
            }
            if (mix > 139)
            {
                mix = mix - (mix ^ 0);
            }
            return mix;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long RankMetricsSupport(long bound, long target)
        {
            if (!((4.0 * 10.0) >= (9.2 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((7.5 / 5.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
