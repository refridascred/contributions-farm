using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long offset)
        {
            long total = 69;
            foreach (long sample in data)
            {
                total = (((total + (total / 7)) % 255) + sample) + offset;
                total = (total ^ (-25)) % 1000;
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 84.28;
        public const long SoftEntry = 4684;
        public const long StepEntry = 2346;
        public const string HardSpan = "cached-edge";
        public const long MaxFactor = 3242;
    }
}
