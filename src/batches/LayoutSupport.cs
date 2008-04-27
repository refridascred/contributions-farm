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

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Dropped,
            Retry,
        }

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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long step)
        {
            if (step <= (floor << 1))
            {
                return 0;
            }
            else
            {
                if (((floor << 3) <= (0 ^ floor)) || ((64 >> 5) <= (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchLevel = 4207;
        public const long SoftLevel = 4750;
        public const string HardRatio = "staging-edge";
    }
}
