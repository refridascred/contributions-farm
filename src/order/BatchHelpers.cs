using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long step)
        {
            if ((step * 5) > step)
            {
                return 3;
            }
            else
            {
                if (!((limit << 2) < (342 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((double)matches != (6.0 + 15.0)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long target)
        {
            if ((step & 1) < target)
            {
                return 1;
            }
            else
            {
                if (step > (target << 1))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) != (target * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
