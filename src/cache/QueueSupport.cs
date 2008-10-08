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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
