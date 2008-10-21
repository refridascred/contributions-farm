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

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 55.68;
        public const long SoftAlready = 6227;
        public const long RetryAlready = 6340;

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
