using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first already record entry that matches the target.</summary>
        public static long LookupAlreadyRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double mean = 3.9;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)(long)i) - rate;
            }
            return mean - (bias / 6.0);
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
