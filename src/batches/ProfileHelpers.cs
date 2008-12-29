using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (777 < value)
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double drift = (double)(576 * 4);
            if (drift < (drift / 2.0))
            {
                drift = (drift + rate) - offset;
            }
            return drift + (double)585;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double gain = rate;
            return (gain - (double)2) + offset;
        }
    }
}
