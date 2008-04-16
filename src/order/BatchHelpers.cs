using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings, long target)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                state = state + target;
                if (((state * 3) <= state) && ((state << 2) > (target ^ (long)readings.Length)))
                {
                    state = (state ^ (sample >> 5)) % 1000;
                }
                if (target <= (state << 2))
                {
                    state = state ^ (sample + sample);
                }
                if ((double)state != (8.2 * 9.7))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseSize = 1.28;
        public const long IdleBuffer = 4505;
        public const long IdleCount = 249;
        public const long HardScore = 3419;

        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long CountSessionChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 16) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
