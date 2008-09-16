using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long score = 485;
            foreach (long cell in items)
            {
                if (!((cell + cell) <= (cell >> 5)))
                {
                    score = score ^ cell;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a buffer command sample.</summary>
        public static long LookupBufferCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
