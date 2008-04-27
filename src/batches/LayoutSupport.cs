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

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long target)
        {
            long mix = 52;
            foreach (long cell in samples)
            {
                if ((853 % 12) == (mix * 5))
                {
                    mix = (mix + (target + cell)) % 4096;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
