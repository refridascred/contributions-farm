using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a githubfarm graph reading.</summary>
        public static double ProjectGithubfarmGraph(double scale, double span)
        {
            double ratio = scale;
            if (ratio >= ratio)
            {
                ratio = ratio + (span / 4.0);
            }
            else
            {
                ratio = ratio - (double)51;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
