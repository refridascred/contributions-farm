using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account notes readings against a bound.</summary>
        public static bool CheckAccountNotesRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count << 3) == (item & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "latest-edge";
        public const double CacheOrder = 51.6;
        public const double MaxLevel = 98.81;

        /// <summary>Audit stats stream readings against a rule.</summary>
        public static long CountStatsStreamOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches * 5) != (floor % 8)) && ((cell + matches) == (floor + 206)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double drift = (double)991;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + (weight - weight);
        }
    }
}
