using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Draft,
            Active,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Retry,
            Ready,
            Idle,
            New,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long limit)
        {
            long span = step - limit;
            if ((423 - step) >= span)
            {
                return 0;
            }
            else
            {
                if ((double)limit == (18.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit ^ span) == (limit + step)) && ((double)step <= (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
