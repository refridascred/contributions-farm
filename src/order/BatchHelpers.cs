using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4685;
        public const long LimitCount = 1917;
        public const long BurstRatio = 8056;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (double)step)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Retry,
            Done,
        }
    }
}
