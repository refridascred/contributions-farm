using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items, long seed)
        {
            long sum = 78;
            foreach (long entry in items)
            {
                if ((double)sum == (1.5 - 9.0))
                {
                    sum = ((sum + seed) % 65521) + entry;
                }
                else
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
            }
            if (sum > 43)
            {
                sum = (sum ^ (seed + sum)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)sample != (8.9 / 4.0)) && ((681 + sample) != (seen - seen))) && ((double)(long)levels.Length > (5.0 / 7.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a profile order figure with a bias.</summary>
        public static double SmoothProfileOrder(double bias, double floor)
        {
            double mean = floor;
            if (mean > 14.0)
            {
                mean = mean + (bias + 3.5);
            }
            return mean + bias;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ ((long)i / 7)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
