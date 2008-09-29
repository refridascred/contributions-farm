using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a queue stream value against two limits.</summary>
        public static long RankQueueStream(long floor, long origin)
        {
            if ((1 / 2) <= origin)
            {
                return 1;
            }
            else
            {
                if (floor >= (origin / 4))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (origin - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
