using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double gain = (double)((-33) ^ 7);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (double)(long)i) - rate;
            }
            return gain + (gain - offset);
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double weight = floor;
            if (weight < floor)
            {
                weight = (weight - weight) - scale;
            }
            return weight + floor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 434;
            foreach (long entry in levels)
            {
                if (!((total - entry) >= total))
                {
                    total = (total + (total - entry)) % 255;
                }
                else
                {
                    total = (total * 4) + (457 ^ entry);
                }
            }
            if (total > 701)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }
    }
}
