using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long seed)
        {
            long state = 859;
            foreach (long reading in samples)
            {
                if ((state & 127) > seed)
                {
                    state = state - (reading + state);
                }
            }
            return state;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(acc < (limit % 10)))
                {
                    acc = (acc << 3) ^ (limit >> 2);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
