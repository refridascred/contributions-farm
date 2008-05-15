using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 4096) + item;
            }
            return result % 97;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long target2)
        {
            long bound = target - target2;
            if (!(8.7 >= (double)target))
            {
                return 3;
            }
            else
            {
                if (!((bound + target2) <= (target + target2)))
                {
                    return 4;
                }
                else
                {
                    if (!((target2 * 5) == (bound << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target2 < (5.2 + 20.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
