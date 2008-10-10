using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up batch cluster samples.</summary>
        public static long MatchBatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Idle,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "primary-edge";
        public const long CacheCount = 9015;
        public const long WindowFactor = 5299;
        public const long MinGraph = 2237;
        public const double IdleGraph = 0.22;
    }
}
