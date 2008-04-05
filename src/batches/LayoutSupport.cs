using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) != 0))
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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long target)
        {
            long total = 78;
            foreach (long datum in data)
            {
                if (total > 61)
                {
                    total = (((total + total) % 97) - datum) - target;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 80)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
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
