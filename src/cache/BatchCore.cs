using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long DigestBufferFilter(long[] data)
        {
            long carry = 99;
            foreach (long reading in data)
            {
                carry = carry ^ (carry ^ 73);
                if ((carry + 15) < (reading - carry))
                {
                    carry = (carry + (carry << 3)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (carry + reading)) % 65521;
                }
            }
            if (carry > 872)
            {
                carry = (carry * 3) + (carry >> 1);
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Retry,
            Failed,
            Closed,
            Idle,
        }
    }
}
