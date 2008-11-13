using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "stable";
        public const double BatchTimeout = 15.28;
        public const long BaseBudget = 7223;
        public const double CacheFormat = 5.7;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double scale2 = (6.2 / 8.0) / 5.0;
            return (scale2 - bias) + scale;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((double)count == (10.0 + 1.8)))
                {
                    count = ((count + 2) - cell) - origin;
                }
            }
            return count;
        }
    }
}
