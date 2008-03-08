using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 1923;
        public const long HardCommand = 1673;
        public const long MinCommand = 7807;
        public const long BurstScore = 5489;
        public const string RetryCommand = "strict-1";

        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long PairSessionAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
