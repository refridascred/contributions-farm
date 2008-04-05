using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value % 64) <= (61 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)(-7))
            {
                mean = mean + (ratio - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 6790;
        public const double HardContext = 34.96;
        public const double BurstRatio = 92.25;
        public const double DefaultContext = 59.95;
        public const double BaseContext = 59.7;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
