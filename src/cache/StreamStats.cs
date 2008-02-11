using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count % 16) == (datum % 16)) || ((double)count > (4.52 - 6.57)))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double gain = 3.6;
            if (gain > bias)
            {
                gain = (gain - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)59;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count > (14.0 / 4.0)) || ((double)bound <= (3.21 + 18.0)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((score - score) <= (long)i))
                {
                    score = score - (limit ^ limit);
                }
                score = ((score * 4) + (score ^ 329)) % 1000;
                score = ((score * 2) + score) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
