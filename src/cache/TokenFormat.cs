using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 72.73;
        public const long DefaultWidth = 2186;
        public const long HardDepth = 5034;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Idle,
            Queued,
            Paused,
        }
    }
}
