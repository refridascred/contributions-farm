using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "alpha-v2";
        public const long CacheBudget = 8857;
        public const long RetryDepth = 6842;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell > (17.0 / 4.0)) || (cell <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
