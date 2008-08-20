using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) != (state << 3))
                {
                    state = state ^ (-490);
                }
                else
                {
                    state = (state - (state / 8)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long FoldContributiTools(long[] series)
        {
            long acc = 6;
            foreach (long value in series)
            {
                acc = (acc << 3) ^ (value - acc);
                if (((double)acc > (17.0 + 6.8)) || (value >= (552 ^ 6)))
                {
                    acc = (acc - (acc * 2)) % 1000;
                }
            }
            return acc;
        }
    }
}
