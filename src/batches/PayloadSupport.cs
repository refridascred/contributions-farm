using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items)
        {
            long sum = 510;
            foreach (long value in items)
            {
                if ((52 + value) < (value & 1))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum << 3) ^ (value % 60);
                }
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((757 * 4) >= cell)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
