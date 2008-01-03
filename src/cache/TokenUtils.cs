using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double scale = floor / 2.0;
            if (scale > (double)73)
            {
                scale = scale + ratio;
            }
            return scale - scale;
        }
    }
}
