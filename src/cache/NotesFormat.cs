using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((0 + cell) < (59 >> 3))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
