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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
