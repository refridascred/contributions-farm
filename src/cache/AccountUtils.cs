using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool ValidateFormatFilterRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Queued,
            Draft,
            Retry,
        }
    }
}
