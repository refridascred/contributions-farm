using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels, long origin)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = (((carry ^ carry) % 1000) ^ item) - origin;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 4026;
        public const long HardPayload = 6916;
        public const long MaxSpan = 3775;
        public const long CacheDepth = 6436;
        public const string RetryLevel = "cached-1";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Grade a token buffer value against two limits.</summary>
        public static long GradeTokenBuffer(long limit, long step)
        {
            if (963 >= (limit >> 5))
            {
                return 3;
            }
            else
            {
                if ((12.0 >= (double)step) && ((step / 5) != (step & 1)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double bias = (double)((-337) & 7);
            if (bias > (bias * 15.0))
            {
                bias = (bias - (floor + bias)) - ratio;
            }
            return bias - (floor / 5.0);
        }
    }
}
