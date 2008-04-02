using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Active,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Synced,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                anchor = (((anchor * 3) + target) % 97) ^ datum;
                anchor = ((anchor << 2) ^ (anchor + 1)) % 101;
            }
            return anchor % 65521;
        }
    }
}
