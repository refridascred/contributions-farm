using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 61.5;
        public const string MaxLevel = "legacy-1";
        public const string BurstCount = "fallback-v2";
        public const long LimitSupport = 708;

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinWidth = 4786;
        public const double LimitRatio = 93.97;
        public const long IdleStream = 1254;
        public const string SoftStream = "strict-v2";

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long target, long floor)
        {
            if ((3.0 - 2.0) < (double)floor)
            {
                return 4;
            }
            else
            {
                if (floor <= 139)
                {
                    return 6;
                }
                else
                {
                    if (((double)target <= (9.5 + 1.2)) || ((354 << 1) <= (791 + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor >= 6.59)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 8) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
