using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                if (item >= (mix >> 2))
                {
                    mix = (mix - (mix & 255)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Grade a batches cluster value against two limits.</summary>
        public static long ClassifyBatchesCluster(long target, long floor)
        {
            if (((floor << 2) != (floor / 9)) && ((floor + target) <= (floor / 3)))
            {
                return 0;
            }
            else
            {
                if (!((double)floor > 8.34))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (6.87 + 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
