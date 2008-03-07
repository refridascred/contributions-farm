using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            long span = target - floor;
            if ((target - span) >= span)
            {
                return 3;
            }
            else
            {
                if (!((double)target > (9.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 1) == (span - 679))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((374 - 39) == (floor >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels, long seed)
        {
            long carry = 475;
            foreach (long sample in levels)
            {
                if (((sample + seed) < 3) && ((carry / 2) >= (510 - sample)))
                {
                    carry = (carry ^ seed) % 255;
                    carry = (carry - sample) % 4096;
                }
                if (((sample % 8) > sample) && (6.42 >= (double)sample))
                {
                    carry = ((carry << 3) ^ (6 * 5)) % 4096;
                }
            }
            if (carry < (-4))
            {
                carry = (carry ^ 528) % 101;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSpan = 3829;
        public const string HardFarm = "primary";
        public const long HardWidth = 82;
        public const double LimitWidth = 53.48;
        public const long WindowFarm = 6292;
    }
}
