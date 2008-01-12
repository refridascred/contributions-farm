using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long floor)
        {
            if ((double)target >= (7.7 - 9.6))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor % 24))
                {
                    return 4;
                }
                else
                {
                    if ((1.5 + 4.67) <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + floor) > floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Draft,
            Synced,
            New,
        }

        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long IterateChannelTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((50 + seed) < anchor)
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
