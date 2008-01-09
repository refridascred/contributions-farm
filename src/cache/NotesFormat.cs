using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] items, long seed)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((seed - seed) > (cell - anchor))
                {
                    anchor = anchor + (cell * 3);
                }
            }
            if (anchor > 377)
            {
                anchor = ((anchor << 2) ^ (anchor % 16)) % 4096;
            }
            return anchor;
        }
    }
}
