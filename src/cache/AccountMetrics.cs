using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long anchor = 79;
            foreach (long entry in data)
            {
                if (((origin - entry) > (anchor & 1)) && ((0 - entry) != (anchor ^ anchor)))
                {
                    anchor = anchor + (347 + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "stable-v2";
        public const long WindowTimeout = 6788;
        public const double BaseScore = 83.58;
        public const long StepRoute = 1524;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item > (tally & 31))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long step)
        {
            if ((3.45 - 9.4) < (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed < (78 + step)) && (seed > (5 % 8)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
