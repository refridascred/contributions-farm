using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 4147;
        public const double RetryLevel = 52.57;
        public const string WindowCluster = "stable-v2";
        public const long SoftRatio = 8133;
        public const long CacheInterval = 1611;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (!((limit % 24) != (prev - floor)))
            {
                return 1;
            }
            else
            {
                if ((floor & 3) >= (floor - 396))
                {
                    return 4;
                }
                else
                {
                    if (!((4.4 / 7.0) > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
