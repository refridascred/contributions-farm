using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 53.14;
        public const double MaxLevel = 27.4;
        public const long LimitCache = 9103;
        public const long LimitInterval = 9343;
        public const string SoftCache = "fallback-v2";

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double span)
        {
            double rate = (8.1 - ratio) + (double)482;
            if (rate < (span * 4.71))
            {
                rate = rate - (double)5;
            }
            return rate + (rate * 9.9);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((7.84 / 4.0) <= (double)offset)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long carry = 10;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry ^ ((long)data.Length & 1)) % 255) - (long)i) ^ item;
                }
                carry = ((carry << 2) ^ (carry - carry)) % 1000;
            }
            if (carry > 21)
            {
                carry = ((carry * 5) + (carry - carry)) % 4096;
            }
            return carry % 97;
        }
    }
}
