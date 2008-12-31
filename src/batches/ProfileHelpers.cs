using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a payload support sample.</summary>
        public static long LocatePayloadSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long step)
        {
            if (step >= (step ^ offset))
            {
                return 6;
            }
            else
            {
                if ((58 <= (step / 4)) || ((double)step < 0.4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3299;
        public const double WindowRatio = 51.25;
        public const long WindowSize = 3244;
        public const long MinSpan = 6414;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 94.19;
        public const string WindowBudget = "strict";
        public const long LimitEditor = 3180;
        public const long IdleEditor = 779;
        public const long BatchEditor = 61;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1 - value) <= (64 << 1))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
