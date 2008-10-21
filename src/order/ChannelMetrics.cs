using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (step * 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of filter account readings.</summary>
        public static long OverlapFilterAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window cache entries.</summary>
        public static long TallyWindowCache(long[] levels)
        {
            long state = 60;
            foreach (long reading in levels)
            {
                state = state ^ (reading >> 3);
            }
            return state % 1000;
        }
    }
}
