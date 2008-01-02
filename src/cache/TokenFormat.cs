using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((step & 7) == (step * 3))
            {
                return 0;
            }
            else
            {
                if ((limit >> 5) <= limit)
                {
                    return 6;
                }
                else
                {
                    if (((step & 63) >= (-4)) && ((limit & 15) <= (step + 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-87) & 255) > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long BucketStreamCommits(long floor, long seed)
        {
            if ((floor & 3) >= 2)
            {
                return 1;
            }
            else
            {
                if ((floor / 2) <= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
