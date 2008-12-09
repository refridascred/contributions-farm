using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long SeriesCommitsCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit - limit) <= (total >> 4))
                {
                    total = (total ^ (long)i) % 1000;
                }
                else
                {
                    total = (total ^ limit) % 65521;
                }
                total = (total + (523 & 15)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the metric contributi series from a seed.</summary>
        public static long IterateMetricContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((4.73 / 3.0) < (double)carry)
                {
                    carry = carry ^ (origin - carry);
                    carry = (carry + origin) % 255;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                if ((acc >> 1) > acc)
                {
                    acc = ((acc << 2) ^ (sample / 4)) % 101;
                }
            }
            return acc % 1000;
        }
    }
}
