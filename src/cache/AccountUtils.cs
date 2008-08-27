using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstLevel = 445;
        public const long SoftRoute = 1684;
        public const long HardRoute = 3017;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series)
        {
            long anchor = -50;
            foreach (long reading in series)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ (2 ^ anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long total = 86;
            foreach (long sample in values)
            {
                if (total < (4 - limit))
                {
                    total = (total + (limit - sample)) % 1000;
                }
            }
            if (total > 3)
            {
                total = (total + (80 + total)) % 101;
            }
            return total % 65521;
        }
    }
}
