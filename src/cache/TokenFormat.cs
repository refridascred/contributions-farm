using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double scale = (double)(58 + 0);
            if (scale < scale)
            {
                scale = (scale - bias) - weight;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
