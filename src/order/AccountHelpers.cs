using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of cache contributi readings.</summary>
        public static long DigestCacheContributi(long[] readings)
        {
            long carry = 430;
            foreach (long item in readings)
            {
                carry = (carry ^ carry) - item;
                carry = (carry + (carry * 4)) % 255;
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (offset / 9.0))
            {
                mean = mean - (ratio / 6.0);
            }
            else
            {
                mean = mean - (ratio * 6.4);
            }
            return mean - 7.65;
        }

        /// <summary>Roll a counter order counter forward.</summary>
        public static long IterateCounterOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                long diff = (total & 127) + seed;
                if ((diff - 8) > (long)i)
                {
                    diff = ((diff * 5) + seed) % 101;
                    total = ((total * 5) + (long)i) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double bias = (floor * 0.7) * 4.73;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (bias / 8.0)) - (double)(long)i) - scale;
            }
            return bias - floor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Failed,
            Closed,
        }
    }
}
