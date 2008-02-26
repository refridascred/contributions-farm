using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long MeasureGithubfarmStreamHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (5.0 > (double)hits)
                {
                    hits = ((hits + 1) + cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double bias = weight * 9.74;
            if (bias >= (bias * 10.0))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (span - span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (7.46 * 11.0)) + (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] data)
        {
            long anchor = 6;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (81 % 16)) - cell;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
