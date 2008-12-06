using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (double)(-37))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)407) + (double)(long)i;
            }
            return bias2 + (8.5 - bias2);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value ^ (long)readings.Length) <= matches)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
