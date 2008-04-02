using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if ((4.5 - 4.3) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((79 >= (offset + offset)) && ((offset2 << 1) < offset2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long step)
        {
            if (((double)step <= (20.0 * 5.24)) || ((double)step > (4.94 + 20.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (6.7 - 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (1.32 * 2.16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.1 + 3.04) > (double)origin) && ((origin << 3) >= 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Paused,
            Locked,
        }
    }
}
