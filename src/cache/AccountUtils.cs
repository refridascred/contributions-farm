using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if (bound > (456 - seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > bound)
                {
                    return 2;
                }
                else
                {
                    if (((double)seed <= (3.8 / 9.0)) || ((2.58 - 6.4) <= (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double ratio = bias2 + (double)76;
            if (ratio > (8.03 / 6.0))
            {
                ratio = ratio - (double)104;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + 20.0;
        }
    }
}
