using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string SoftScore = "local-edge";
        public const long HardWindow = 1865;
        public const long MinWindow = 5377;
        public const double BaseTimeout = 85.93;
        public const long BurstWindow = 5686;

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)reading == (5.58 - 9.06)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
