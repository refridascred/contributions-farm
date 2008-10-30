using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long origin)
        {
            if ((origin / 9) <= origin)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) > (origin >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > (double)0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Idle,
            Done,
        }
    }
}
