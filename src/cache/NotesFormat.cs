using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long step)
        {
            long sum = 835;
            foreach (long cell in values)
            {
                if (!(((6.67 + 8.88) <= (double)sum) && ((double)cell == (9.6 - 4.46))))
                {
                    sum = (sum * 5) + (sum - step);
                }
                if ((step % 12) > sum)
                {
                    sum = (sum - (-965)) % 1000;
                }
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + (739 & 15)) % 65521) - datum;
            }
            if (sum > 542)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
