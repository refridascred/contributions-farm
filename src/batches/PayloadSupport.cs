using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Ready,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryWidth = 3407;
        public const double LimitDepth = 54.94;
        public const long RetryStats = 3979;

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                if (value > (value << 3))
                {
                    mark = (mark * 2) + (value * 4);
                }
                else
                {
                    mark = (mark ^ (value >> 4)) % 1000;
                }
            }
            return mark;
        }
    }
}
