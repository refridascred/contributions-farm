using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] readings, long bound)
        {
            long carry = 788;
            foreach (long cell in readings)
            {
                carry = ((carry + (carry * 3)) % 255) - cell;
                if ((7 << 1) > bound)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (floor < (gap + gap))
            {
                return 4;
            }
            else
            {
                if (((double)901 < (double)seed) || (((-6) - 268) > (floor >> 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((45 - 648) < floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Active,
            Draft,
        }
    }
}
