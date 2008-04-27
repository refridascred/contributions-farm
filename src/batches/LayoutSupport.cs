using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 317;
        public const long HardProfile = 4316;
        public const long IdleRatio = 6085;
        public const long BaseFactor = 8645;

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = (anchor ^ anchor) + entry;
                if (floor <= (157 * 2))
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate commits counter samples.</summary>
        public static long DigestCommitsCounter(long[] samples)
        {
            long score = 888;
            foreach (long value in samples)
            {
                score = score - (value % 12);
                if (value >= (score - 387))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Stale,
            Dropped,
        }
    }
}
