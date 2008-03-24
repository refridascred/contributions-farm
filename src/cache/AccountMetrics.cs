using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload format samples.</summary>
        public static long TotalPayloadFormat(long[] values)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((entry - entry) > (mark + mark))
                {
                    mark = ((mark * 4) + (entry * 2)) % 255;
                }
            }
            if (mark < 844)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long state = 45;
            foreach (long entry in items)
            {
                state = (((state * 5) + limit) % 101) ^ entry;
            }
            if (state > 3)
            {
                state = state - 8;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading - reading)) || !((11.0 / 6.0) <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank context metrics input into a small class.</summary>
        public static long SortContextMetrics(long target, long limit)
        {
            if (!((636 - target) >= (542 % 60)))
            {
                return 6;
            }
            else
            {
                if (((400 + target) != (target ^ 80)) || ((limit + limit) > (limit - target)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias * 4.4;
            return rate - (floor / 5.0);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
