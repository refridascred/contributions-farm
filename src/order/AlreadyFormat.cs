using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long offset)
        {
            if ((7.0 + 5.19) != (double)target)
            {
                return 4;
            }
            else
            {
                if (!((offset / 8) >= (0 << 1)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (9.53 * 19.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate command checks samples.</summary>
        public static long FoldCommandChecks(long[] levels, long bound)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((68 + acc) >= (entry + acc))
                {
                    acc = ((acc - (acc % 7)) % 65521) - bound;
                }
                else
                {
                    acc = (acc ^ 8) % 1000;
                    acc = ((acc << 2) ^ 640) % 1000;
                }
                acc = ((acc << 3) ^ (entry ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double load = (11.0 + weight) * 7.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)(-86)) + (double)(long)i) - bias;
            }
            return load - weight;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
