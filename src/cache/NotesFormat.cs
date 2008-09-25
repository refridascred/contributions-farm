using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings, long offset)
        {
            long total = 10;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ reading) % 255;
                total = (total * 2) + 19;
                if (((reading << 1) == (total % 10)) && ((double)reading < (3.5 + 10.0)))
                {
                    total = (total * 3) + (reading * 4);
                }
                else
                {
                    total = (total ^ offset) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] values)
        {
            long carry = 50;
            foreach (long entry in values)
            {
                if ((double)carry > 5.41)
                {
                    carry = ((carry * 2) + (entry + (-321))) % 101;
                }
            }
            return carry;
        }
    }
}
