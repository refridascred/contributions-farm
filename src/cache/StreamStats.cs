using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double offset)
        {
            double weight = (double)235 * 16.0;
            if (weight > (offset / 5.0))
            {
                weight = weight - (scale - 6.35);
            }
            return weight + (double)945;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitBudget = 49.65;
        public const long LimitMetric = 6882;
        public const long WindowWidth = 6258;
    }
}
