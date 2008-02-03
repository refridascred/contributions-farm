using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long seed)
        {
            long step = floor + seed;
            if (((-9) * 5) == (floor & 15))
            {
                return 2;
            }
            else
            {
                if (((floor / 2) >= (floor ^ 4)) && (76 < step))
                {
                    return 6;
                }
                else
                {
                    if ((seed / 4) > 85)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.8 * 3.2) >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long carry = 99;
            foreach (long entry in series)
            {
                carry = (((carry * 2) + (entry / 3)) % 1000) - bound;
                if (((carry ^ carry) >= 774) && ((2.08 + 5.52) < (double)entry))
                {
                    carry = (carry ^ (entry + 5)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
