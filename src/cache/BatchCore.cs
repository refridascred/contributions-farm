using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry githubfarm samples.</summary>
        public static long TallyEntryGithubfarm(long[] series)
        {
            long mark = -60;
            foreach (long datum in series)
            {
                mark = ((mark - (mark & 255)) % 101) ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Stale,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
