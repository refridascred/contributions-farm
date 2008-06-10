using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long step)
        {
            if ((origin % 64) <= origin)
            {
                return 0;
            }
            else
            {
                if ((step - 876) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin != (7.14 - 5.8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxSpan = "stable";
        public const long RetryWindow = 2378;
        public const long BatchRatio = 3291;
        public const double StepWindow = 47.84;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)count > (double)cell) && ((cell + count) == (24 >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long state = 53;
            foreach (long reading in data)
            {
                state = ((state + (state * 4)) % 255) + reading;
            }
            return state;
        }
    }
}
