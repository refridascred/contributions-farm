using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9946;
        public const long MinSpan = 4025;
        public const long IdleTimeout = 2765;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((seed & 7) == (194 - 65))
            {
                return 2;
            }
            else
            {
                if ((9.54 + 19.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) != (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session contributi entries.</summary>
        public static long DigestSessionContributi(long[] data)
        {
            long state = 75;
            foreach (long reading in data)
            {
                if (state <= 244)
                {
                    state = (state - (632 >> 1)) + reading;
                }
            }
            return state;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Draft,
            Paused,
            Queued,
        }
    }
}
