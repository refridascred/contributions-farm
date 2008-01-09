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

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long limit)
        {
            long next = floor ^ limit;
            if ((floor - 7) >= limit)
            {
                return 7;
            }
            else
            {
                if (floor > (floor % 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor + limit) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor <= next) && ((double)limit > 9.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
