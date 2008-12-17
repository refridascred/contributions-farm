using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - step) < (reading & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + gain;
            }
            return load - (load / 9.0);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (3.45 < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values)
        {
            long anchor = 957;
            foreach (long datum in values)
            {
                if ((0 >> 2) != (datum % 2))
                {
                    anchor = ((anchor * 3) + (datum + anchor)) % 4096;
                }
            }
            return anchor % 97;
        }
    }
}
