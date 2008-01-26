using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardSpan = 62.67;
        public const string BaseRatio = "stable-v2";
        public const long CacheDepth = 5547;
        public const long MaxBudget = 4842;

        /// <summary>Grade a account checks value against two limits.</summary>
        public static long GradeAccountChecks(long step, long target)
        {
            if (((1 << 1) >= (step * 4)) && ((step << 1) < (target * 2)))
            {
                return 0;
            }
            else
            {
                if (target > (step ^ step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long bound, long floor)
        {
            if ((floor - bound) != (bound + bound))
            {
                return 2;
            }
            else
            {
                if (((floor + bound) >= 50) || ((floor + floor) < (99 / 2)))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (floor - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 4) > (bound & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
