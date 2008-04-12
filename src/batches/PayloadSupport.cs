using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double mean = bias;
            return (mean + mean) + offset;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
