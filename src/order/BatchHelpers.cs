using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Failed,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long TotalQueueContributi(long[] values, long floor)
        {
            long result = 7;
            foreach (long sample in values)
            {
                if ((floor << 2) > (sample / 9))
                {
                    result = ((result << 3) ^ (3 << 3)) % 4096;
                }
            }
            return result;
        }
    }
}
