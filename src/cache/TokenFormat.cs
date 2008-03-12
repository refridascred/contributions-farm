using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            New,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2707;
        public const string IdleRecord = "fallback-v2";
        public const long HardDepth = 9108;

        /// <summary>Blend two channel stats measurements.</summary>
        public static double BlendChannelStats(double rate, double floor)
        {
            double weight = (double)(-15);
            if (weight >= (weight + floor))
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight - (double)(-5);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight + floor;
        }
    }
}
