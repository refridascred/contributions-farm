using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 8540;
        public const long MaxSession = 8486;
        public const long SoftWidth = 2898;
        public const string RetryInterval = "fallback";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double bias = offset / 7.0;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)7) + (double)(long)i) + weight;
            }
            return bias + offset;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)floor > (double)3)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            long next = bound + floor;
            if ((bound - 3) < (next + bound))
            {
                return 3;
            }
            else
            {
                if ((floor <= (619 + floor)) || ((54 / 5) != (next - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > (1.8 - 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)next >= (8.9 * 16.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
