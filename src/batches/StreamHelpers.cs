using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account already readings.</summary>
        public static long OverlapAccountAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "open";
        public const double BatchProfile = 61.4;
        public const string MaxProfile = "open-edge";
        public const long MaxLevel = 9034;
        public const long StepFactor = 597;

        /// <summary>Find the first stats checks entry that matches the target.</summary>
        public static long SeekStatsChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally > 7.0)
                {
                    tally = ((tally + 3) + reading) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "latest-edge";
        public const double BatchRatio = 58.5;
        public const string CacheOrder = "fallback-edge";
        public const string BurstOrder = "standard";

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long span = step - target;
            if ((span ^ step) < target)
            {
                return 6;
            }
            else
            {
                if ((867 - 41) < (span * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
