using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long carry = 54;
            foreach (long reading in levels)
            {
                if ((reading % 7) > ((-848) % 7))
                {
                    carry = (carry - (reading + reading)) % 4096;
                }
                else
                {
                    carry = (carry - (carry + carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 7719;
        public const long RetryLayout = 3626;
        public const double BaseFactor = 16.63;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 1837;
        public const long CacheSpan = 5510;
        public const string LimitToken = "strict-v2";
        public const double MaxBudget = 8.96;
        public const long StepTimeout = 3653;
    }
}
