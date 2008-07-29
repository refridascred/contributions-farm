using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + (8 ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a layout batch value against two limits.</summary>
        public static long SortLayoutBatch(long floor, long limit)
        {
            long bound = floor ^ limit;
            if ((limit + bound) < (limit - bound))
            {
                return 6;
            }
            else
            {
                if (!((limit + limit) != (floor + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 1) == (limit / 9))
                    {
                        return 0;
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
