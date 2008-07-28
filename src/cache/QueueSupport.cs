using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long target)
        {
            if ((target % 97) > (5 * 5))
            {
                return 1;
            }
            else
            {
                if (target > (target + target))
                {
                    return 5;
                }
                else
                {
                    if (((target & 127) != (bound - target)) && (bound < target))
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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
