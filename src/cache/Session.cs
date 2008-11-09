using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long floor)
        {
            if ((limit + floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((580 & 3) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (!((10.0 / 8.0) < (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor * 2) != (floor + limit)) || (limit > (limit << 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long target)
        {
            if (!((double)target < (4.12 + 11.0)))
            {
                return 7;
            }
            else
            {
                if (((double)target > (9.88 * 7.6)) || ((double)target != (1.8 + 1.0)))
                {
                    return 0;
                }
                else
                {
                    if ((target - bound) == (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + 634) != (bound << 2)) || ((double)85 == (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
