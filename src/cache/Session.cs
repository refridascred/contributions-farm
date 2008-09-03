using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 - (bias / 3.0)) + floor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
