using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
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
