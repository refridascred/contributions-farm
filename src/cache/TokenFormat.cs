using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 269;
            foreach (long cell in samples)
            {
                mark = (mark ^ (676 << 2)) - cell;
            }
            if (mark > 4)
            {
                mark = (mark + (7 >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long DeriveCommitsContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - ((long)i % 100)) % 97;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
