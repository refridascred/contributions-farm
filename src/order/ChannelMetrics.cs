using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                long tally = bound;
                if ((tally * 2) < total)
                {
                    total = (total - (6 ^ total)) % 101;
                    total = ((total << 2) ^ (tally & 255)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
