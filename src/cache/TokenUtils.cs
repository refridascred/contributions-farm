using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank window schema input into a small class.</summary>
        public static long SortWindowSchema(long limit, long floor)
        {
            if (((double)limit == (7.32 * 13.0)) || (954 > (floor + limit)))
            {
                return 2;
            }
            else
            {
                if (!((double)limit != (3.9 - 17.0)))
                {
                    return 0;
                }
                else
                {
                    if (!((450 ^ floor) > (535 * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor >= (floor << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                double drift = 9.14;
                if (!((drift * 12.0) > drift))
                {
                    drift = drift + 7.11;
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
