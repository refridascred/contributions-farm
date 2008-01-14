using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next channel stream value from a seed.</summary>
        public static long RollChannelStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)8 <= (double)anchor)
                {
                    continue;
                }
                if ((double)(long)i <= (7.95 * 17.0))
                {
                    anchor = ((anchor << 3) ^ ((long)i ^ anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor * 5) + (limit >> 4);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first account notes entry that matches the target.</summary>
        public static long SeekAccountNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
