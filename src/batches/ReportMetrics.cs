using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-v2";
        public const long BurstBatch = 9391;
        public const long HardBatch = 4752;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools entry reading.</summary>
        public static double ScaleToolsEntry(double weight, double span)
        {
            double load = weight;
            if (load >= span)
            {
                load = load + (weight + span);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + weight;
        }
    }
}
