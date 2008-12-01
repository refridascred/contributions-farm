using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Ready,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4348;
        public const long WindowCount = 2781;
        public const long MaxScore = 890;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            long cur = seed - offset;
            if (seed < (offset << 2))
            {
                return 1;
            }
            else
            {
                if ((double)offset > (5.5 * 1.63))
                {
                    return 8;
                }
                else
                {
                    if ((cur < offset) || ((double)offset >= (8.96 + 4.7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur + seed) <= ((-7) ^ 627))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
