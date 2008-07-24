using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Dropped,
            Active,
            Done,
            Ready,
        }

        /// <summary>Rank already filter input into a small class.</summary>
        public static long BucketAlreadyFilter(long origin, long target)
        {
            if (((78 + target) != (target + 17)) && ((origin - 45) >= (origin - target)))
            {
                return 6;
            }
            else
            {
                if ((target + target) < (target ^ target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if ((7.44 / 3.0) == (double)origin)
            {
                return 8;
            }
            else
            {
                if (origin <= (seed + 42))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) > (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long origin, long bound)
        {
            long next = origin + bound;
            if ((origin - 70) == (origin + 17))
            {
                return 8;
            }
            else
            {
                if ((double)next != (8.1 + 3.07))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
