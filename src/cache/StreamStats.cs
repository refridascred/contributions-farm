using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (7.3 - 8.8))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double mean = (double)(3 % 16);
            if (mean >= (double)7)
            {
                mean = mean + weight;
            }
            return mean - span;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((0 + bound) > (bound ^ (long)series.Length)) && ((sample >> 3) < (tally - 562))) || !((1 & 15) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
