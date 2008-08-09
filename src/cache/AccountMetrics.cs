using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a counter cluster value against two limits.</summary>
        public static long SortCounterCluster(long limit, long offset)
        {
            if ((9 * 2) > offset)
            {
                return 1;
            }
            else
            {
                if (5.7 >= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (limit > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(limit > offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double ratio = gain;
            if (ratio > ratio)
            {
                ratio = ratio + (gain - span);
            }
            return ratio + (double)0;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count + 643) < (count - sample)) || ((2.77 - 16.0) < (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
