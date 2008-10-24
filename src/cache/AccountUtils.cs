using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if (limit > (-6))
            {
                return 6;
            }
            else
            {
                if (((limit & 31) > (limit % 5)) || ((double)bound > 2.4))
                {
                    return 2;
                }
                else
                {
                    if ((limit - bound) > (limit - 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit != (18.0 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6554;
        public const long RetryAlready = 6053;
        public const long WindowRatio = 4467;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Synced,
            Idle,
            Failed,
        }
    }
}
