using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 260;
        public const double WindowMetrics = 49.37;
        public const string RetryInterval = "fallback-1";
        public const string StepMetrics = "local-1";
        public const string SoftMetrics = "fallback-v2";

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Dropped,
            New,
            Closed,
            Failed,
        }
    }
}
