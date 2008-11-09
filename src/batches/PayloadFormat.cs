using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryBudget = "open-v2";
        public const long SoftCount = 5519;
        public const long IdleCounter = 2463;
        public const long BurstCounter = 5023;
        public const long MinCounter = 4283;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long origin)
        {
            long delta = offset + origin;
            if (((double)delta != (double)origin) && ((5.6 * 3.44) > (double)origin))
            {
                return 6;
            }
            else
            {
                if ((delta + 4) <= (offset * 5))
                {
                    return 1;
                }
                else
                {
                    if (!((origin << 1) < 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (5.99 - 3.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long carry = 559;
            foreach (long reading in levels)
            {
                carry = carry ^ (carry << 2);
                if (carry > (carry >> 3))
                {
                    carry = ((carry * 3) + 4) % 65521;
                    continue;
                }
                if ((carry + reading) < reading)
                {
                    carry = (carry - (reading - reading)) % 1000;
                }
            }
            if (carry > 690)
            {
                carry = carry ^ (carry + (long)levels.Length);
            }
            return carry;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if ((19.0 + 10.0) == (double)acc)
                {
                    continue;
                }
                acc = ((acc ^ (acc & 127)) % 1000) - sample;
            }
            if (acc < 3)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
