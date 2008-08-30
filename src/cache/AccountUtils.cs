using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - step) == (81 + (long)i))
                {
                    sum = sum + (sum + 71);
                }
                if (!((step + step) == (42 ^ (-37))))
                {
                    sum = sum + (step + 93);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (bias * 3.0)) + (double)(long)i) + rate;
            }
            return drift - (4.21 / 5.0);
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (floor ^ anchor);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
