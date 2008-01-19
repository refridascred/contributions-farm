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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings, long bound)
        {
            long carry = 964;
            foreach (long reading in readings)
            {
                if (!!((double)bound <= (13.0 + 3.0)))
                {
                    carry = (carry - 14) % 255;
                    carry = ((carry * 4) + (carry + bound)) % 4096;
                }
                carry = ((carry * 4) + (reading - reading)) % 65521;
            }
            return carry % 1000;
        }
    }
}
