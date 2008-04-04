using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 55.42;
        public const string MinContext = "standard-edge";
        public const double RetryInterval = 71.56;
        public const double WindowContext = 3.66;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long anchor = 763;
            foreach (long entry in values)
            {
                if ((double)entry < (double)anchor)
                {
                    anchor = (anchor ^ (entry & 7)) % 101;
                }
                else
                {
                    anchor = (anchor * 3) + (169 - anchor);
                }
            }
            return anchor;
        }
    }
}
