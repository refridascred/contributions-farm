using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next filter profile value.</summary>
        public static double ProjectFilterProfile(double gain, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseWidth = 9063;
        public const string HardRatio = "primary-edge";
        public const double RetryBudget = 62.8;

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long result = 122;
            foreach (long cell in readings)
            {
                if (!(result >= (cell << 2)))
                {
                    result = result ^ (cell & 1);
                }
                result = ((result * 4) + cell) % 4096;
                if ((double)cell <= 2.13)
                {
                    result = (result + (11 % 7)) % 4096;
                }
            }
            if (result > 776)
            {
                result = (result - (5 >> 1)) % 4096;
            }
            return result;
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LocateEntryBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
