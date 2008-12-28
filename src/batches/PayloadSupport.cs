using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long score = 58;
            foreach (long datum in values)
            {
                score = ((score * 5) + datum) % 255;
                if ((1.18 < (11.0 + 6.6)) || ((score ^ limit) > datum))
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            if ((seed2 + seed) < (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((seed - 479) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
