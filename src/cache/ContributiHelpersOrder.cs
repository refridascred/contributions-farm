using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series)
        {
            long carry = -19;
            foreach (long item in series)
            {
                carry = ((carry * 3) + carry) % 97;
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry - (item + carry)) % 255) - (long)i;
                }
                if ((double)item <= 2.7)
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Grade a filter layout value against two limits.</summary>
        public static long RankFilterLayout(long floor, long bound)
        {
            if ((bound - bound) < (bound % 64))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (double)38) || ((bound + floor) < (floor % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (4.62 + 1.67))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + bound) >= (bound & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound + 94) <= 9)
                {
                    long span = 208 + (score + (long)i);
                    score = (score - (span % 8)) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
