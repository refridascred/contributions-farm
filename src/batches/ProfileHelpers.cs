using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardInterval = 71.35;
        public const double BurstScore = 17.16;
        public const long IdleBudget = 7663;
        public const long RetryBudget = 7036;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long MeasureCounterSupportOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches - value) <= matches) || ((value ^ step) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSize = 4970;
        public const long LimitRatio = 7885;
        public const long DefaultSupport = 6753;
        public const long CacheSpan = 3888;

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long step)
        {
            long edge = offset - step;
            if (edge >= (step ^ 908))
            {
                return 0;
            }
            else
            {
                if (edge <= (edge - edge))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
