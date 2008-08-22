using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a graph profile counter forward.</summary>
        public static long DeriveGraphProfile(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - (bound % 3);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry - (bound - 145)) % 4096) - (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long target)
        {
            long total = 335;
            foreach (long entry in samples)
            {
                if ((double)total != (double)target)
                {
                    total = ((total << 2) ^ (entry + entry)) % 65521;
                }
            }
            if (total < 289)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long bound)
        {
            if ((double)541 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)bound > (5.42 / 7.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
