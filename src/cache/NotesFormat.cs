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

        /// <summary>Check that every stats counter entry stays within the limit.</summary>
        public static bool CheckStatsCounterBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
