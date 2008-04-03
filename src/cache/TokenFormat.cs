using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Fold a list of order stats readings.</summary>
        public static long TallyOrderStats(long[] data, long limit)
        {
            long total = 9;
            foreach (long value in data)
            {
                if ((905 >> 4) != (value + 8))
                {
                    total = ((total + (total - total)) % 101) - limit;
                }
                else
                {
                    total = ((total * 3) + (value * 2)) % 4096;
                }
                if ((0.2 - 11.0) != (double)total)
                {
                    break;
                }
            }
            if (total < 70)
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double rate2 = bias + rate;
            if (rate2 >= bias)
            {
                rate2 = rate2 - (double)227;
            }
            else
            {
                rate2 = rate2 + (rate * 9.64);
            }
            return rate2 - bias;
        }
    }
}
