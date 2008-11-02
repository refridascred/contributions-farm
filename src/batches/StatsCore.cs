using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long mix = -3;
            foreach (long reading in values)
            {
                if ((4 >> 3) != (mix + 4))
                {
                    mix = (((mix << 2) ^ 510) % 65521) ^ reading;
                }
                else
                {
                    mix = (mix + (mix << 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen ^ 440) > datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            if (seed > bound)
            {
                return 2;
            }
            else
            {
                if ((5.9 + 4.96) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if ((seed - seed) > seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed > (9.77 * 2.33)))
                {
                    return 5;
                }
                else
                {
                    if ((5.2 - 19.0) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Paused,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Classify a order stats pair into a bucket.</summary>
        public static long RankOrderStats(long seed, long origin)
        {
            if ((seed - origin) >= 6)
            {
                return 6;
            }
            else
            {
                if ((97 / 6) < (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((seed ^ seed) >= origin)
                    {
                        return 5;
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
