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

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "staging-1";
        public const double StepBudget = 0.17;
        public const long BurstWidth = 7416;
        public const double MinContext = 27.62;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + ((long)i * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
