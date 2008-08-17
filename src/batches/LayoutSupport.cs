using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long floor)
        {
            long bound = limit + floor;
            if ((floor ^ bound) >= (85 * 5))
            {
                return 0;
            }
            else
            {
                if ((6.65 * 8.5) == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor <= (0.87 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor * 5) > (limit ^ limit)) || ((7.8 * 20.0) > (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next record batches value from a seed.</summary>
        public static long IterateRecordBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (33 & 15)) % 1000;
                carry = ((carry << 2) ^ (carry >> 5)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                if (((cell / 6) < ((-5) - carry)) && (1.38 <= (double)carry))
                {
                    carry = (carry + (cell + cell)) % 1000;
                }
                if ((cell + carry) >= 981)
                {
                    carry = ((carry * 3) + (cell & 1)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
