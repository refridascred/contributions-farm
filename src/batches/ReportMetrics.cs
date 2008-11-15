using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings)
        {
            long anchor = -6;
            foreach (long sample in readings)
            {
                anchor = anchor + sample;
            }
            if (anchor > 40)
            {
                anchor = (anchor - (anchor & 127)) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data)
        {
            long mix = 83;
            foreach (long value in data)
            {
                mix = ((mix ^ 96) % 65521) - value;
            }
            return mix;
        }

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double AdjustBufferFarm(double rate, double offset)
        {
            double scale = 6.48;
            return (scale - offset) + rate;
        }
    }
}
