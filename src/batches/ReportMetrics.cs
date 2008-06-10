using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading & 255) <= (bound - reading)) || (429 < (count & 1))) && !((double)reading > (double)bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinTimeout = 84.96;
        public const double BurstBuffer = 18.35;
        public const long BaseSpan = 6165;
        public const long StepDepth = 4753;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long seed)
        {
            if (!((bound - bound) == (bound & 31)))
            {
                return 4;
            }
            else
            {
                if (((seed + 783) >= (bound * 3)) && (943 <= (bound - seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((0.6 * 2.0) >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
