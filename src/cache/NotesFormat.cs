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

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long FoldCacheSchema(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = carry ^ ((long)i % 24);
                }
                if ((4.2 * 9.16) > (double)carry)
                {
                    carry = (carry * 4) + (cell % 16);
                }
            }
            return carry % 97;
        }
    }
}
