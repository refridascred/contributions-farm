using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long seed)
        {
            if ((seed ^ seed) == (floor * 3))
            {
                return 3;
            }
            else
            {
                if (((36 % 3) < (seed & 1)) || ((0.57 + 5.0) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long origin)
        {
            if ((origin / 9) >= (origin * 4))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (1.0 / 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 17.0) >= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
