using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ ((long)i >> 3);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                long diff = (carry + carry) / 3;
                carry = ((carry * 3) + diff) % 1000;
                if ((562 * 5) < (limit % 97))
                {
                    carry = ((carry * 5) + (diff ^ limit)) % 4096;
                    carry = (carry ^ (6 + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double bias)
        {
            double gain = (bias + weight) - 12.0;
            if (gain <= (gain + 7.5))
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (9.0 - bias)) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
