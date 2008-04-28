using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long floor)
        {
            if ((floor % 64) > (floor << 3))
            {
                return 3;
            }
            else
            {
                if ((target + floor) < target)
                {
                    return 2;
                }
                else
                {
                    if (target > 36)
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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Retry,
            Locked,
            Done,
        }
    }
}
