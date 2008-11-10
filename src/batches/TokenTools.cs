using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "alpha-edge";
        public const long MinContributi = 3114;
        public const long SoftDepth = 8419;
        public const long WindowContributi = 4662;
        public const string MinFactor = "fallback-v2";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
