using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long seed)
        {
            if ((seed > target) || (6 >= (seed * 2)))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 345) == (target / 3))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target + target)) && ((seed + seed) >= (target & 31)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 + seed) > (target - seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route notes readings against a bound.</summary>
        public static bool CheckRouteNotesLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 6405;
        public const long IdleSize = 5866;
        public const string HardTimeout = "latest-v2";
        public const long IdleLevel = 7354;
        public const double MaxCache = 21.15;
    }
}
