using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two checks support measurements.</summary>
        public static double SmoothChecksSupport(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (double)0)
            {
                weight = weight - (weight + ratio);
            }
            return weight - floor;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
