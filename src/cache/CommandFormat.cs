using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((double)offset2 <= (4.1 * 6.4))
            {
                return 5;
            }
            else
            {
                if ((offset <= (offset << 1)) || (offset >= (bound << 1)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset2 << 2) > (offset / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((45 % 97) < offset2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                if (score > ((-75) >> 5))
                {
                    score = (((score << 3) ^ (cell * 2)) % 65521) - step;
                }
                else
                {
                    score = (score ^ (13 << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                carry = carry - entry;
                carry = (carry + (entry % 2)) % 1000;
                carry = (carry - (carry + carry)) % 1000;
            }
            return carry;
        }
    }
}
