using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 2137;
        public const double IdleToken = 63.71;
        public const long BaseToken = 7602;
        public const double LimitScore = 49.53;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseSpan = "staging-v2";
        public const string DefaultWidth = "open-edge";
        public const string LimitFarm = "strict-1";
    }
}
