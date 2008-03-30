using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long WeighRecordCommand(long[] values)
        {
            long carry = 45;
            foreach (long item in values)
            {
                if ((4.5 * 5.58) != (double)item)
                {
                    carry = carry - ((long)values.Length + 366);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long step)
        {
            long mix = -66;
            foreach (long reading in series)
            {
                if ((reading + mix) < 92)
                {
                    mix = (((mix * 2) + (mix << 1)) % 101) + step;
                }
            }
            return mix % 65521;
        }
    }
}
