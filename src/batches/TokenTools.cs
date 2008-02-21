using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((matches - cell) >= (matches ^ matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Retry,
            Closed,
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long TallySessionStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length >= (7.1 + 9.0))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
