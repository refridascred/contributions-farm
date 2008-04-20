using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits report pairs that satisfy a relation.</summary>
        public static long OverlapCommitsReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a route record pair into a bucket.</summary>
        public static long GradeRouteRecord(long target, long origin)
        {
            long lane = target ^ origin;
            if (lane >= (target - target))
            {
                return 4;
            }
            else
            {
                if ((lane > (lane + origin)) && ((0 + 5) <= (lane - 6)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 9770;
        public const long RetryFilter = 9332;
        public const double SoftSpan = 97.99;
        public const string SoftSize = "strict-edge";
    }
}
