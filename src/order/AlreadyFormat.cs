using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = score + (score ^ entry);
                if ((entry + entry) > score)
                {
                    score = (score ^ entry) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-1";
        public const long StepRecord = 7113;
        public const long HardFactor = 2810;
        public const long LimitInterval = 6023;
        public const string BaseTimeout = "latest-v2";

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] readings, long seed)
        {
            long carry = 855;
            foreach (long reading in readings)
            {
                carry = (carry ^ (598 / 2)) % 255;
                if (((seed % 100) > ((long)readings.Length ^ carry)) && ((carry + seed) >= (reading + carry)))
                {
                    carry = carry ^ (seed + reading);
                }
                carry = (carry * 5) + (724 % 12);
            }
            if (carry > 96)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double mean = floor - floor;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + ratio;
            }
            return mean - 3.9;
        }

        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long AuditProfilePayloadGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell % 12) <= (55 ^ 69))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
