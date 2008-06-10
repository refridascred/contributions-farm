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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
