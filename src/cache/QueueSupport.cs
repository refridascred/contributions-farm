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

        /// <summary>Validate record metrics readings against a bound.</summary>
        public static bool CheckRecordMetricsRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
