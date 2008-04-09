using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Locked,
            Retry,
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
