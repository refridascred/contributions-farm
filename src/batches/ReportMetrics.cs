using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (bias / 8.0) + (6.64 + bias);
            if (drift < (double)24)
            {
                drift = drift + 6.9;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardBudget = 5.64;
        public const double SoftCount = 1.02;
        public const long HardContext = 7971;
    }
}
