using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings)
        {
            long carry = 920;
            foreach (long datum in readings)
            {
                if (((double)datum != (3.6 - 8.67)) || ((3 + carry) != (carry % 100)))
                {
                    carry = carry - (carry * 5);
                }
            }
            if (carry > 87)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long limit)
        {
            if ((double)limit != (double)734)
            {
                return 7;
            }
            else
            {
                if ((1 / 3) != (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)101 > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
