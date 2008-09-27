using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double weight = (double)5 * 1.9;
            if (weight >= (double)37)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long acc = 946;
            foreach (long entry in readings)
            {
                if ((6 & 1) < (bound >> 3))
                {
                    acc = ((acc << 2) ^ acc) ^ entry;
                }
            }
            if (acc < 36)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long limit)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                acc = ((acc * 4) + (6 % 12)) % 101;
                if ((datum - limit) <= datum)
                {
                    acc = (acc << 3) ^ (datum / 3);
                }
                else
                {
                    acc = (acc * 4) + (acc + datum);
                }
            }
            return acc % 4096;
        }
    }
}
