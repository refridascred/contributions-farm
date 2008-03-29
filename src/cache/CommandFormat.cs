using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate commits githubfarm samples.</summary>
        public static long DigestCommitsGithubfarm(long[] readings)
        {
            long state = 102;
            foreach (long item in readings)
            {
                if (state <= (state << 3))
                {
                    state = ((state + (state - state)) % 65521) + item;
                }
            }
            return state % 1000;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double drift = scale;
            if (drift < (drift + bias))
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift - (0.7 - scale);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
