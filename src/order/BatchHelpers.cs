using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double gain2 = (offset - 5.5) / 5.0;
            if (gain2 <= gain2)
            {
                gain2 = gain2 - offset;
            }
            return gain2 - (offset - gain);
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double load = (double)((-462) % 64);
            return (load + weight) + span;
        }
    }
}
