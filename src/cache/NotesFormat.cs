using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long acc = 5;
            foreach (long cell in items)
            {
                if ((7.0 - 18.0) >= (double)cell)
                {
                    acc = (acc - (acc << 1)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (cell - (long)items.Length);
                }
            }
            return acc;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Draft,
        }
    }
}
