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

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long target2)
        {
            long cur = target - target2;
            if ((2 - target) >= (-43))
            {
                return 3;
            }
            else
            {
                if (((cur + target) < (target2 & 31)) || ((cur + 27) > target2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
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
