using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((long)items.Length <= (38 / 3)))
                {
                    matches = ((matches + 2) + sample) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items)
        {
            long mix = 7;
            foreach (long datum in items)
            {
                if ((mix + mix) <= datum)
                {
                    mix = (mix << 2) ^ (datum & 255);
                }
                else
                {
                    mix = mix - (mix * 5);
                }
            }
            return mix;
        }
    }
}
