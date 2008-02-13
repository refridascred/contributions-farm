using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (carry - (long)i)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ offset) % 97) - (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = ((carry ^ (carry + offset)) % 97) ^ (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
