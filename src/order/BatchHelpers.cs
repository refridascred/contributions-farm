using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two cluster entry measurements.</summary>
        public static double BlendClusterEntry(double gain, double floor)
        {
            double scale = floor;
            if (scale >= (floor / 9.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (gain / 6.0)) - (double)(long)i;
            }
            return scale - 0.6;
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
