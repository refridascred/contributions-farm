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

        /// <summary>Roll a buffer layout counter forward.</summary>
        public static long IterateBufferLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound + 785) != (long)i)
                {
                    total = ((total * 3) + (bound + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

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
