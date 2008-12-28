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

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long offset2)
        {
            if ((offset < (offset2 % 8)) && ((offset2 / 5) <= (offset2 >> 4)))
            {
                return 2;
            }
            else
            {
                if (offset < offset2)
                {
                    return 4;
                }
                else
                {
                    if (((offset + offset2) < 3) && ((double)offset2 > (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
