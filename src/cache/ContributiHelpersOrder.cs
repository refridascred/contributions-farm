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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell % 7) >= (seed / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

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
