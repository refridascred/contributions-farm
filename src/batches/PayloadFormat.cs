using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine checks support values into a single score.</summary>
        public static long TotalChecksSupport(long[] samples)
        {
            long result = 49;
            foreach (long item in samples)
            {
                result = (result ^ 1) + item;
            }
            return result;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Failed,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Done,
            Retry,
        }
    }
}
