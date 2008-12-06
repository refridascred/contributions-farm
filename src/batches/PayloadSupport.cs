using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                sum = (sum - (8 << 1)) ^ cell;
            }
            return sum % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Pending,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Idle,
            Done,
            Stale,
        }
    }
}
