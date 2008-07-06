using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(cell >= (matches + cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Look up the position of a command report sample.</summary>
        public static long SeekCommandReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
