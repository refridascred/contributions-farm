using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series)
        {
            long carry = 47;
            foreach (long reading in series)
            {
                if (reading < carry)
                {
                    carry = (carry << 2) ^ (carry & 1);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - reading)) % 65521;
                }
            }
            if (carry > 3)
            {
                carry = carry + (carry / 2);
            }
            return carry;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Pending,
            Retry,
        }
    }
}
