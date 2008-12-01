using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long step)
        {
            if ((20.0 + 0.41) <= (3.9 - 10.0))
            {
                return 2;
            }
            else
            {
                if ((step <= 37) && (step <= 55))
                {
                    return 8;
                }
                else
                {
                    if (!((step + step) <= (step * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target / 9) < (320 - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 65.3;
        public const long MinEditor = 6997;
        public const long IdleScore = 8980;
        public const long MaxSize = 7705;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
