using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double scale2 = (offset / 5.0) - scale;
            if (scale2 < 16.0)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + offset;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
