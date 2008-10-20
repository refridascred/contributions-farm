using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 40;
            foreach (long item in items)
            {
                total = ((total << 3) ^ (item % 60)) % 65521;
                total = total ^ (item - 8);
                if ((4.5 / 4.0) == (double)total)
                {
                    total = ((total << 3) ^ (total - total)) % 1000;
                }
            }
            if (total > 3)
            {
                total = (total ^ (total & 255)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Dropped,
            Active,
            Queued,
            Locked,
        }
    }
}
