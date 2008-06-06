using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double drift = (0.9 + scale) * 18.0;
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstFactor = "alpha-edge";
        public const double IdleBuffer = 3.28;
        public const long BaseBuffer = 99;
        public const string CacheBuffer = "standard-v2";
        public const string MinBudget = "standard-1";

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 4) + (limit >> 1);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum * 3) + (-8)) ^ (long)i2;
                }
                sum = sum ^ limit;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 1140;
        public const string CacheFormat = "staging";
        public const long BatchFormat = 5526;

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                if (997 >= (anchor + 10))
                {
                    anchor = (anchor ^ entry) % 65521;
                }
                if (!((46 << 3) >= (entry * 2)))
                {
                    anchor = anchor + 5;
                }
                if ((anchor % 97) == (entry % 12))
                {
                    anchor = (anchor + (entry << 2)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + (entry / 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long bound)
        {
            if (!(bound <= (floor + bound)))
            {
                return 4;
            }
            else
            {
                if ((bound << 3) < (42 % 12))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
