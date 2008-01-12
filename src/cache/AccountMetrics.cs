using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] series, long origin)
        {
            long state = -69;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (state + (reading >> 3)) ^ (long)i;
                    state = (state * 4) + reading;
                }
                if ((8.32 * 1.5) <= (double)state)
                {
                    state = state - (origin + state);
                }
                else
                {
                    state = (state << 3) ^ (3 % 7);
                }
            }
            if (state < 339)
            {
                state = ((state * 4) + (origin ^ state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 90.59;
        public const long IdleCache = 6095;
        public const long RetryCache = 8957;
        public const long StepLevel = 4222;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 6912;
        public const string StepFactor = "local-1";
        public const double SoftEditor = 22.84;
        public const double SoftBudget = 46.26;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
