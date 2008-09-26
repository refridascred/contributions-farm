using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long CountChannelBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) != ((long)series.Length + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples)
        {
            long anchor = 718;
            foreach (long item in samples)
            {
                if (item <= (anchor << 3))
                {
                    anchor = ((anchor * 3) + item) % 4096;
                    anchor = anchor + (anchor % 97);
                }
                else
                {
                    anchor = ((anchor * 5) + (9 - anchor)) % 4096;
                }
                anchor = anchor + anchor;
            }
            if (anchor < 421)
            {
                anchor = (anchor ^ (anchor - 45)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
