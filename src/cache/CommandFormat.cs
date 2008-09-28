using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3.26 - 3.7) >= (double)offset)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen >> 5) != (seen & 7))
                {
                    seen = ((seen + 1) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] items)
        {
            long result = 119;
            foreach (long reading in items)
            {
                result = result + reading;
            }
            return result % 97;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = floor - rate;
            if (mean <= (rate / 3.0))
            {
                mean = mean - 12.0;
            }
            else
            {
                mean = mean + (mean * 1.7);
            }
            return mean + floor;
        }
    }
}
