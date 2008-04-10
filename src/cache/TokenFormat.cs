using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 541;
            foreach (long datum in items)
            {
                if ((mix + mix) < (14 + 4))
                {
                    mix = (((mix << 2) ^ mix) % 4096) + datum;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items, long offset)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                if (!(472 < (long)items.Length))
                {
                    anchor = (anchor ^ (offset - datum)) % 65521;
                }
            }
            if (anchor > 53)
            {
                anchor = ((anchor * 2) + (anchor + offset)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
