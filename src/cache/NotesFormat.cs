using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Done,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Grade a command batch value against two limits.</summary>
        public static long SortCommandBatch(long limit, long origin)
        {
            if (((limit / 6) >= 994) || ((double)(-81) <= (double)origin))
            {
                return 8;
            }
            else
            {
                if (limit >= (origin ^ limit))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit < 4.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
