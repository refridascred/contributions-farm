using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "legacy";
        public const long HardScore = 6793;
        public const long LimitQueue = 3108;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command cache value against two limits.</summary>
        public static long RankCommandCache(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin2 * 3) != (3 + 777))
            {
                return 6;
            }
            else
            {
                if ((7.4 / 7.0) < (double)origin2)
                {
                    return 5;
                }
                else
                {
                    if ((origin + 53) > (delta + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
