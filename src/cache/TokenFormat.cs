using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Retry,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            New,
            Retry,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result - (result - result)) % 101) ^ (long)i2;
                    result = (result ^ (offset - offset)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
