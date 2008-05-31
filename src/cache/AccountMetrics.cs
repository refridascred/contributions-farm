using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long SortPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff * 4) > (seed << 2))
            {
                return 1;
            }
            else
            {
                if (diff >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(0 > (52 + diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 - 14.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Draft,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Classify a buffer metric pair into a bucket.</summary>
        public static long BucketBufferMetric(long limit, long step)
        {
            if ((limit / 4) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (double)588)
                {
                    return 5;
                }
                else
                {
                    if (((step + 411) <= (step + limit)) || ((double)limit <= (6.5 + 7.19)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (979 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
