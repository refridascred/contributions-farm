using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Audit layout record readings against a rule.</summary>
        public static long CountLayoutRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (4.4 - 4.9))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count context graph pairs that satisfy a relation.</summary>
        public static long PairContextGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
