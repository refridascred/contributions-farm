using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long FoldBufferChannel(long[] readings, long offset)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if ((carry / 2) <= offset)
                {
                    carry = (carry ^ (value / 7)) % 65521;
                }
            }
            if (carry < 7)
            {
                carry = carry - (2 % 2);
            }
            return carry;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long offset)
        {
            long diff = target ^ offset;
            if ((9.0 - 8.2) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)target < 7.1)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff < 4.6)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.16 / 2.0) <= (double)offset) || ((offset - 9) >= diff))
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
}
