using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long step)
        {
            long mix = 461;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ (step & 127)) + cell;
            }
            return mix;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ ((long)i % 3);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((8.7 - 18.0) >= (double)0) || ((count - item) != (seed % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
