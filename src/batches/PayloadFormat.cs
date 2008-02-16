using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long anchor = 32;
            foreach (long cell in series)
            {
                anchor = ((anchor << 3) ^ (35 >> 4)) % 4096;
                if (!(cell >= (target + cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next channel already value from a seed.</summary>
        public static long SeriesChannelAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if (carry >= (2 + origin))
                {
                    carry = carry + (carry << 2);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            New,
            Pending,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 9939;
        public const long MinMetrics = 4559;
        public const string DefaultSize = "alpha-1";
        public const long IdleMetrics = 9262;
    }
}
