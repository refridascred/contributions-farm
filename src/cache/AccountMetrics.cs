using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Closed,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Idle,
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches cluster samples.</summary>
        public static long CombineBatchesCluster(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if ((mix > (-80)) || ((double)bound <= 7.0))
                {
                    mix = ((mix ^ (mix + bound)) % 255) - item;
                }
            }
            return mix;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long step2)
        {
            if (((double)step > 0.7) || ((step2 - step2) > step))
            {
                return 5;
            }
            else
            {
                if ((step2 << 3) >= (2 >> 1))
                {
                    return 8;
                }
                else
                {
                    if (((step % 3) <= (step + step)) && ((double)step == (double)step2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 <= (862 >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3612;
        public const long MaxCount = 3951;
        public const double DefaultBuffer = 82.35;
    }
}
