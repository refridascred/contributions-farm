using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Failed,
            Done,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((acc * 4) > acc)
                {
                    acc = (acc + (item / 7)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
