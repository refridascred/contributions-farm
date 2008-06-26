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

        /// <summary>Fold a list of editor entry readings.</summary>
        public static long FoldEditorEntry(long[] items, long floor)
        {
            long total = 130;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ ((long)items.Length - datum)) - floor;
            }
            return total % 65521;
        }
    }
}
