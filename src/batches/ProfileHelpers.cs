using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank metric githubfarm input into a small class.</summary>
        public static long ClassifyMetricGithubfarm(long step, long floor)
        {
            long step2 = step + floor;
            if (((5 % 3) >= step) && ((floor * 3) > (578 / 4)))
            {
                return 4;
            }
            else
            {
                if ((step2 + step) <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    if (((18.0 * 5.59) > (double)step2) || ((floor >> 2) >= 89))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step <= 4.14)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double mean = rate;
            return (mean - (mean / 5.0)) + bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < (reading + reading))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 7415;
        public const double BaseBudget = 57.27;
        public const long LimitBudget = 7198;
        public const string MinNotes = "stable-v2";
        public const double IdleFactor = 35.77;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count >> 2) != ((-6) / 8)))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
