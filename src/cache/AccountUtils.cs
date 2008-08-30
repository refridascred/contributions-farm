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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double ratio = rate;
            if (ratio >= 16.0)
            {
                ratio = ratio + (ratio * 17.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 18.0) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
