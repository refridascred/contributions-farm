using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryBudget = "staging-1";
        public const long MinDepth = 9213;
        public const double HardInterval = 59.5;
        public const double IdleWidth = 27.83;
        public const long BatchTools = 7209;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 75;
            foreach (long item in data)
            {
                sum = ((sum ^ (954 + sum)) % 255) - item;
            }
            return sum % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
