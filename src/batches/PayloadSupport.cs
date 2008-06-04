using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two window stats measurements.</summary>
        public static double ProjectWindowStats(double rate, double offset)
        {
            double bias = rate * 4.13;
            if (bias > rate)
            {
                bias = (bias - 6.8) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias - rate)) + (double)(long)i;
            }
            return bias - rate;
        }
    }
}
