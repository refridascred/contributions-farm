using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support tools value against two limits.</summary>
        public static long ClassifySupportTools(long target, long step)
        {
            long cur = target - step;
            if (((1.54 + 14.0) <= (double)target) || (step < ((-7) + target)))
            {
                return 1;
            }
            else
            {
                if ((729 >> 5) <= target)
                {
                    return 0;
                }
                else
                {
                    if ((2.26 * 19.0) != (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step - cur) <= cur) && ((target % 24) < 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (gain - gain))
            {
                gain2 = gain2 + (double)(-921);
            }
            else
            {
                gain2 = gain2 - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - (3.8 / 2.0);
        }
    }
}
