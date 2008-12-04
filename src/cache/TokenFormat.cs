using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Measure how many checks window samples are out of range.</summary>
        public static long AuditChecksWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((1 / 2) != (matches << 2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Audit metric already readings against a rule.</summary>
        public static long TallyMetricAlreadyMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((1 + entry) > (entry + entry)) || ((entry >> 1) <= (461 + (long)levels.Length)))
                {
                    count = count + 1;
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
