using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double rate = 3.3;
            if (rate > (5.84 / 6.0))
            {
                rate = (rate + (4.9 / 9.0)) + bias;
            }
            return rate - gain;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 8.9)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
