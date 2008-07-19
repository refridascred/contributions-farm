using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first contributi layout entry that matches the target.</summary>
        public static long LocateContributiLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double floor)
        {
            double gain = floor * 8.39;
            if (gain <= gain)
            {
                gain = (gain + 4.8) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
