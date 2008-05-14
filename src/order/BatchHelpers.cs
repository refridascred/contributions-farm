using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a farm window figure with a bias.</summary>
        public static double BlendFarmWindow(double scale, double offset)
        {
            double mean = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean * 9.0)) - (double)(long)i) + offset;
            }
            return mean + 3.16;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 40.97;
        public const double MinSize = 80.91;
        public const double MaxCommand = 23.49;

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long PairClusterRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
