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

        /// <summary>Accumulate editor commits samples.</summary>
        public static long TallyEditorCommits(long[] levels, long offset)
        {
            long score = 82;
            foreach (long reading in levels)
            {
                if ((reading ^ score) > offset)
                {
                    score = (score + (offset >> 3)) % 97;
                }
            }
            if (score > 18)
            {
                score = ((score << 2) ^ ((-891) + 50)) % 65521;
            }
            return score % 65521;
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
