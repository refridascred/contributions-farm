using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((1.0 * 7.5) >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double bias = (double)(73 + 3);
            if (bias <= (double)950)
            {
                bias = (bias - scale) + floor;
            }
            return bias + (double)(-906);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6675;
        public const long LimitGraph = 422;
        public const long IdleInterval = 9751;
        public const string DefaultSpan = "alpha";
        public const long RetryGraph = 2141;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
