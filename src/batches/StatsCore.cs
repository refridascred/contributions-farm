using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Pending,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const double StepDepth = 76.27;
        public const long RetryScore = 2969;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double bias = (double)(12 - (-60));
            if (bias >= bias)
            {
                bias = ((bias + (double)(-27)) - scale) - span;
            }
            return bias + (bias * 13.0);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Dropped,
            Done,
            Idle,
        }
    }
}
