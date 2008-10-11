using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long mark = 96;
            foreach (long entry in series)
            {
                if ((mark + mark) >= (mark * 2))
                {
                    mark = ((mark ^ 88) ^ entry) - offset;
                }
            }
            return mark;
        }

        /// <summary>Roll a checks batches counter forward.</summary>
        public static long IterateChecksBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target - anchor) >= anchor)
                {
                    anchor = anchor - (anchor * 3);
                }
                anchor = anchor - (anchor - 141);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a notes cache value against two limits.</summary>
        public static long SortNotesCache(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((double)limit >= (6.65 + 9.4))
            {
                return 8;
            }
            else
            {
                if (((lane + lane) < (735 * 3)) || ((double)limit >= 2.5))
                {
                    return 5;
                }
                else
                {
                    if ((lane + limit) < (665 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchInterval = "primary-1";
        public const long BatchBatches = 1806;
        public const double HardScore = 60.3;
        public const long IdleBatches = 646;

        /// <summary>Derive the next order account value from a seed.</summary>
        public static long StepOrderAccount(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (state + 6)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
