using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((origin * 3) != (score * 5)))
                {
                    score = (score + (origin << 1)) % 97;
                    score = score + (2 / 2);
                }
                if ((origin << 1) == (origin ^ origin))
                {
                    score = score - score;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
