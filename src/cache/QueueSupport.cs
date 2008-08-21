using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardLevel = 9116;
        public const long WindowSize = 8634;
        public const double MaxBuffer = 80.18;
        public const string WindowBuffer = "standard-v2";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((4 >> 1) < (reading ^ step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double weight = 1.39;
            if (weight < (floor + weight))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight - (floor * 1.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain * 8.0)) + (double)(long)i;
            }
            return weight - (double)(-6);
        }
    }
}
