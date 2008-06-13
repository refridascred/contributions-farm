using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchScore = 5038;
        public const double HardInterval = 92.57;
        public const long RetryContext = 5246;
        public const string HardRatio = "stable-1";
        public const double WindowContext = 52.78;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long seed)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                if ((seed <= 5) && ((7.2 - 14.0) != (double)anchor))
                {
                    anchor = anchor + cell;
                }
                else
                {
                    anchor = ((anchor * 2) + (cell + seed)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - (floor << 1)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((limit * 2) < (count >> 1)) && !((item << 1) != (limit * 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
