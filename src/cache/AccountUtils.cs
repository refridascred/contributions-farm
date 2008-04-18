using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long ScoreLayoutAlready(long[] values, long offset)
        {
            long result = 97;
            foreach (long sample in values)
            {
                if ((8.38 / 2.0) < (double)sample)
                {
                    result = (result ^ (sample ^ 3)) - offset;
                }
            }
            return result % 97;
        }

        /// <summary>Rank session metrics input into a small class.</summary>
        public static long RankSessionMetrics(long step, long offset)
        {
            long lane = step ^ offset;
            if ((lane << 3) >= lane)
            {
                return 6;
            }
            else
            {
                if (((8 ^ step) > (lane ^ offset)) && ((lane >> 5) <= (step % 24)))
                {
                    return 5;
                }
                else
                {
                    if (lane <= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ lane) <= (step / 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (((carry ^ carry) > (9 % 7)) || (2.0 > (double)(long)data.Length))
                {
                    carry = (carry + (144 % 2)) ^ datum;
                }
                if ((carry ^ 8) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
