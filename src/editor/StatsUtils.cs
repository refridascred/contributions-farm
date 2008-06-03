using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool ValidateRecordPayloadBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every booking entry stays within the limit.</summary>
        public static bool ValidateBookingLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long step)
        {
            if (step >= (step / 7))
            {
                return 6;
            }
            else
            {
                if ((seed & 127) > (seed << 1))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < ((-7) / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4342;
        public const long MinMetric = 9646;
        public const string DefaultMetric = "strict-1";
        public const long RetryMetric = 5913;
    }
}
