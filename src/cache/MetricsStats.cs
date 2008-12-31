using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next farm tools value from a seed.</summary>
        public static long IterateFarmTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < (sum & 31))
                {
                    sum = (sum << 3) ^ (sum << 2);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            if ((2.8 + 2.1) != (double)limit)
            {
                return 3;
            }
            else
            {
                if (!(bound >= (99 * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((bound - 39) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) >= (limit & 127))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = total - (47 % 8);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((seed * 2) < (step + step))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) >= (step + seed)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
