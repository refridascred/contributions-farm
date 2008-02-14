using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long offset, long limit)
        {
            long gap = offset ^ limit;
            if ((offset + 672) <= (gap * 4))
            {
                return 0;
            }
            else
            {
                if ((offset - gap) == (offset - limit))
                {
                    return 1;
                }
                else
                {
                    if ((5 * 2) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset & 3) != (limit & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Idle,
            Active,
            Queued,
            New,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long step, long floor)
        {
            long lane = step ^ floor;
            if (!((step << 2) < (lane * 2)))
            {
                return 0;
            }
            else
            {
                if (step <= 4)
                {
                    return 3;
                }
                else
                {
                    if ((step <= (floor - lane)) || (step > (lane + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
