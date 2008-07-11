using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double rate2 = (double)((-77) >> 2);
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 + (9.0 + 9.52)) + (double)(long)i) - rate;
            }
            return rate2 + (9.2 - floor);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                long offset = (70 + limit) + ((long)i / 7);
                if (((long)i & 1) <= (carry & 1))
                {
                    offset = ((offset << 2) ^ (offset - limit)) % 4096;
                    carry = (carry << 3) ^ ((long)i + offset);
                }
                else
                {
                    carry = carry - (limit & 63);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long target)
        {
            if (!((double)target < (double)54))
            {
                return 8;
            }
            else
            {
                if ((target > (floor - target)) && (floor > (23 - target)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)target >= (double)335))
                    {
                        return 3;
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
