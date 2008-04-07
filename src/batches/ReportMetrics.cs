using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 70.63;
        public const long StepSize = 8955;
        public const long BatchScore = 8992;
        public const string BurstProfile = "latest-v2";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record account figure with a bias.</summary>
        public static double ScaleRecordAccount(double ratio, double offset)
        {
            double gain = ratio * 13.0;
            if (gain <= (gain / 6.0))
            {
                gain = gain + (double)355;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 18.0) + (double)(long)i;
            }
            return gain + (offset + offset);
        }
    }
}
