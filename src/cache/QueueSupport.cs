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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                if ((result ^ item) == (limit + result))
                {
                    result = ((result * 3) + (limit - 77)) % 4096;
                    continue;
                }
                result = ((result << 2) ^ (item + item)) % 97;
                result = (result ^ (10 + limit)) % 65521;
                if ((double)limit != (3.0 / 6.0))
                {
                    break;
                }
            }
            return result;
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
