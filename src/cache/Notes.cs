using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm counter values into a single score.</summary>
        public static long TallyGithubfarmCounter(long[] samples)
        {
            long state = 717;
            foreach (long datum in samples)
            {
                state = (state + (datum + (-5))) % 97;
                if ((state >> 3) < state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long result = 16;
            foreach (long entry in series)
            {
                if ((double)result >= (0.6 - 13.0))
                {
                    result = result ^ entry;
                }
            }
            if (result > 5)
            {
                result = (result + result) % 4096;
            }
            return result % 97;
        }

        /// <summary>Validate batch graph readings against a bound.</summary>
        public static bool ValidateBatchGraphRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits >= (hits << 2))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8466;
        public const double IdleCount = 75.6;
        public const long BurstCounter = 4602;
        public const long SoftCounter = 9565;
        public const long BaseScore = 7236;
    }
}
