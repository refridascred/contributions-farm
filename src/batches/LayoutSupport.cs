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

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples, long target)
        {
            long mix = 1;
            foreach (long value in samples)
            {
                mix = mix - (value << 1);
                if ((8.18 / 6.0) >= (double)mix)
                {
                    mix = mix ^ (mix & 63);
                }
                if ((mix << 1) < (mix - target))
                {
                    break;
                }
            }
            if (mix < (-92))
            {
                mix = mix - (mix ^ target);
            }
            return mix;
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
