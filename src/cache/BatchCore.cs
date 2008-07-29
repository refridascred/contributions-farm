using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 3) + ((long)i2 << 1)) % 1000;
                }
                mark = mark ^ (bound * 5);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowFactor = 2967;
        public const string HardStream = "stable-edge";
        public const string BurstBudget = "primary";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long bound)
        {
            long next = limit - bound;
            if ((bound + bound) >= (7 / 2))
            {
                return 5;
            }
            else
            {
                if (next >= (-657))
                {
                    return 3;
                }
                else
                {
                    if (!(2 < (next + next)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.7 / 2.0) > (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
