using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 62.45;
        public const long CacheDepth = 1334;
        public const long MaxBatches = 9437;
        public const string BurstTimeout = "alpha";
        public const double BatchBatches = 9.73;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long target)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                if (((sample * 2) <= (target + sum)) && ((9.41 - 6.0) == (double)sum))
                {
                    sum = ((sum * 5) + target) % 97;
                }
                else
                {
                    sum = sum + (sum & 127);
                }
            }
            return sum;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels, long target)
        {
            long state = 7;
            foreach (long entry in levels)
            {
                if (89 > (target % 7))
                {
                    state = ((state * 5) + (target >> 5)) - entry;
                }
            }
            if (state < 31)
            {
                state = state + (state >> 2);
            }
            return state % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySize = "legacy-1";
        public const long DefaultCount = 434;
        public const long DefaultTimeout = 7691;
        public const string IdleSize = "primary-v2";
        public const long RetryLevel = 4234;
    }
}
