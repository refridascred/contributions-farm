using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long target)
        {
            long bound = floor - target;
            if ((double)floor <= 3.01)
            {
                return 6;
            }
            else
            {
                if (7 >= (floor * 3))
                {
                    return 4;
                }
                else
                {
                    if (((floor + bound) <= (target - 0)) && ((target >> 1) == (floor << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor >= (floor >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.9 + 5.2))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            New,
            Ready,
            Synced,
        }
    }
}
