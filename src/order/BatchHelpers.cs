using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i + offset) != (carry ^ offset)) || ((carry + offset) != ((long)i - (long)i)))
                {
                    carry = (carry + offset) % 101;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long limit)
        {
            long delta = seed - limit;
            if (((delta >> 2) != (limit ^ seed)) || ((double)seed == (double)limit))
            {
                return 5;
            }
            else
            {
                if ((double)limit > (15.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit <= 8.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)delta != (1.0 / 8.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
