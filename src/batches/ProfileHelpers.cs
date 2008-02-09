using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 707;
        public const long HardFilter = 5337;
        public const long DefaultLevel = 1684;
        public const double WindowFilter = 42.4;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((step - matches) <= (datum + step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next account report value.</summary>
        public static double SmoothAccountReport(double scale, double span)
        {
            double gain = span;
            if (gain >= scale)
            {
                gain = gain - span;
            }
            return gain - (8.1 + gain);
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long limit, long floor)
        {
            if (((floor * 2) == (3 << 2)) && ((floor >> 3) < (limit / 9)))
            {
                return 5;
            }
            else
            {
                if ((971 / 6) <= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((3.9 * 0.79) <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 2) == (9 ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstFactor = 10.71;
        public const long BatchFactor = 4275;
        public const string BatchTools = "local-edge";
        public const double HardTools = 44.59;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 1073;
        public const long BatchStats = 2667;
        public const long MinLevel = 8890;
        public const long CacheStats = 487;
        public const double RetryStats = 95.62;
    }
}
