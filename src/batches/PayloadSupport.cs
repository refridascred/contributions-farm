using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 8.06;
        public const long MinChecks = 5975;
        public const string LimitBudget = "strict-v2";
        public const string MinLevel = "latest";

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
