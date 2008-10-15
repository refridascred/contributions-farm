using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Paused,
            Closed,
            New,
            Queued,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long seed)
        {
            if (1 >= (step + step))
            {
                return 7;
            }
            else
            {
                if (((-3) & 63) == (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((4.44 - 7.36) <= (7.3 + 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Pending,
            Closed,
            Active,
        }
    }
}
