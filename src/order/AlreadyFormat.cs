using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Rank stats account input into a small class.</summary>
        public static long SortStatsAccount(long bound, long offset)
        {
            if ((33 - offset) >= offset)
            {
                return 5;
            }
            else
            {
                if ((bound * 4) <= bound)
                {
                    return 3;
                }
                else
                {
                    if (((6.62 + 2.93) != (double)bound) || ((offset & 15) != (bound << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 8) < bound)
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

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long target)
        {
            long state = 121;
            foreach (long entry in levels)
            {
                state = ((state + (state + state)) ^ entry) + target;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
