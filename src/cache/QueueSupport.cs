using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Closed,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Digest a series of profile githubfarm entries.</summary>
        public static long TallyProfileGithubfarm(long[] samples)
        {
            long mark = 987;
            foreach (long entry in samples)
            {
                mark = (mark ^ entry) % 101;
            }
            if (mark < 65)
            {
                mark = (mark * 2) + 81;
            }
            return mark % 97;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Active,
            Retry,
            New,
            Ready,
        }
    }
}
