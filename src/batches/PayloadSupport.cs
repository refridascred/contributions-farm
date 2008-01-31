using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Pending,
            New,
            Failed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Failed,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a batch cluster sample.</summary>
        public static long LocateBatchClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
