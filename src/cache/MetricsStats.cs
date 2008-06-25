using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            if ((double)step <= 15.0)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (14.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((508 % 97) != (step % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) == ((-725) - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count >= (1.95 / 7.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
