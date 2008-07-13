using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (0.3 < (double)tally)
                {
                    tally = ((tally + 2) + cell) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double load = rate - (double)990;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) + (double)(long)i) - bias;
            }
            return load + (double)1;
        }
    }
}
