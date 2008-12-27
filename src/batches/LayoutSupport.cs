using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double ratio = floor - 6.3;
            if (ratio <= 14.0)
            {
                ratio = ratio + (bias + bias);
            }
            return ratio + floor;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "standard-1";
        public const long LimitMetrics = 6756;
        public const long LimitCount = 2078;

        /// <summary>Adjust a record order reading.</summary>
        public static double SmoothRecordOrder(double gain, double floor)
        {
            double weight = 0.02;
            if (weight <= (9.0 / 3.0))
            {
                weight = (weight + gain) - floor;
            }
            return weight + (4.1 - gain);
        }
    }
}
