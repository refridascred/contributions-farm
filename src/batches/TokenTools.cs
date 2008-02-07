using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 4) + (origin >> 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two commits order measurements.</summary>
        public static double ProjectCommitsOrder(double scale, double floor)
        {
            double mean = (double)(5 + 571);
            if (mean <= (double)(-11))
            {
                mean = mean + (mean / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (floor - floor)) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
