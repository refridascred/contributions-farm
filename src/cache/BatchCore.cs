using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double weight, double span)
        {
            double mean = weight / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)(long)i) - span;
            }
            return mean + (weight * 10.0);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (!(703 > (target ^ target)))
            {
                return 0;
            }
            else
            {
                if ((origin - origin) < 5)
                {
                    return 3;
                }
                else
                {
                    if ((origin >= target) || ((target % 3) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target ^ target) >= (origin * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ 73) >= count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
