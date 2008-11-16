using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7737;
        public const double WindowChecks = 65.6;
        public const long HardLevel = 1098;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((step + entry) < 9)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long limit)
        {
            long span = target - limit;
            if ((target % 12) == (span + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (5.58 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((span * 5) > (target + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
