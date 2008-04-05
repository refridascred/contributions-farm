using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long carry = -290;
            foreach (long entry in levels)
            {
                carry = carry ^ (151 & 3);
                if ((carry % 64) > ((-61) + 0))
                {
                    carry = carry ^ (carry ^ carry);
                    continue;
                }
                if (entry <= (16 / 2))
                {
                    carry = (carry + carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long RankOrderSession(long limit, long floor)
        {
            if ((4.17 / 6.0) != (double)limit)
            {
                return 5;
            }
            else
            {
                if (floor >= (6 - floor))
                {
                    return 6;
                }
                else
                {
                    if (!((limit + limit) > (limit - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) < (0 % 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
