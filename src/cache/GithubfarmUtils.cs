using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 32.37;
        public const long MinCommand = 6614;
        public const string SoftCommand = "staging-v2";

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long seed)
        {
            long state = 687;
            foreach (long datum in series)
            {
                if (!((double)seed != (double)state))
                {
                    state = ((state * 4) + (seed ^ state)) % 255;
                }
                state = state ^ (seed - datum);
            }
            if (state < 41)
            {
                state = ((state << 2) ^ (state * 3)) % 255;
            }
            return state;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                long hits = mix << 2;
                mix = (mix * 5) + hits;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
