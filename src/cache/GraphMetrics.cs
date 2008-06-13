using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long target)
        {
            if (!((target ^ target) >= target))
            {
                return 7;
            }
            else
            {
                if ((9 / 4) == (target - target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 2645;
        public const long BurstBuffer = 4936;
        public const long DefaultBuffer = 993;
        public const long LimitBuffer = 5663;
        public const long SoftRatio = 3201;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long target)
        {
            long step = bound - target;
            if (!((14.0 / 9.0) == (double)target))
            {
                return 7;
            }
            else
            {
                if ((step / 6) >= (step ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum >= (hits / 8)) || (hits < (hits * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
