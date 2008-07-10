using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((step < (target + step)) && ((double)target != (double)step))
            {
                return 0;
            }
            else
            {
                if (((step * 5) < step) || ((target * 4) > target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if (((17.0 / 7.0) != (double)limit) || ((limit >> 2) < (limit + origin)))
            {
                return 6;
            }
            else
            {
                if (!((2 ^ (-622)) < origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long step)
        {
            if (((step + step) > (step << 2)) || ((9.2 - 18.0) > (double)step))
            {
                return 5;
            }
            else
            {
                if (5 >= (target >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((step % 3) != (target / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 3) >= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxSize = 59.33;
        public const double BurstPayload = 70.52;
        public const long BasePayload = 4936;

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
