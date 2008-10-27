using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double bias = 3.0;
            if (bias <= (7.59 * 3.33))
            {
                bias = (bias + (double)96) - weight;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (bias - span);
        }
    }
}
