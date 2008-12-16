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

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total * 5) + (736 & 255)) + (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = ((total - total) % 101) - (long)i3;
                    total = (total + (seed % 24)) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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
