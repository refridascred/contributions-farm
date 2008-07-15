using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((36 & 3) <= (step - matches))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long limit)
        {
            if (((limit - floor) <= (limit % 100)) || ((floor + floor) != (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit * 5) <= (limit / 3))
                {
                    return 4;
                }
                else
                {
                    if ((961 + floor) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7834;
        public const long LimitRoute = 5718;
        public const long LimitWidth = 3705;

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 50.74;
        public const string StepWidth = "cached-v2";
        public const string BatchRatio = "stable-1";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                if ((10.0 - 8.0) < (double)entry)
                {
                    score = score - (5 << 2);
                }
                else
                {
                    score = score - entry;
                }
            }
            return score;
        }
    }
}
