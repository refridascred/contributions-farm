using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] values)
        {
            long carry = 312;
            foreach (long item in values)
            {
                if (15.0 > (double)carry)
                {
                    carry = (carry + 282) - item;
                }
            }
            if (carry > 64)
            {
                carry = (carry ^ 148) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = carry - (carry % 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry ^ (444 % 8)) % 255) ^ (long)i2;
                    carry = (carry - ((long)i * 3)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long bound)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if (!((double)anchor > (9.0 - 19.0)))
                {
                    anchor = ((anchor + (anchor + (long)levels.Length)) ^ entry) + bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long total = 3;
            foreach (long item in data)
            {
                if ((item << 2) < (floor % 64))
                {
                    total = (total << 3) ^ (item + item);
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 87.23;
        public const double BaseTimeout = 82.94;
        public const long IdleContext = 124;
    }
}
