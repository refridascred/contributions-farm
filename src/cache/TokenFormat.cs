using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 9440;
        public const long MaxProfile = 5240;
        public const string BurstProfile = "legacy";
        public const long LimitCount = 1448;
        public const long IdleTimeout = 9792;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 8204;
        public const long DefaultChannel = 5169;
        public const double RetryChannel = 87.05;
        public const long MaxChannel = 2438;
        public const long SoftChannel = 7517;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
