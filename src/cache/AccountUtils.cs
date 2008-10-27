using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values)
        {
            long result = 598;
            foreach (long reading in values)
            {
                if ((result % 7) > result)
                {
                    result = result + (reading / 2);
                }
            }
            return result;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            New,
            Draft,
            Closed,
            Locked,
        }
    }
}
