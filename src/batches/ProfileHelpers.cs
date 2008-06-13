using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values, long floor)
        {
            long total = 579;
            foreach (long datum in values)
            {
                if ((total + total) <= datum)
                {
                    total = (((total << 3) ^ (total % 2)) % 1000) + floor;
                }
                if ((double)(long)values.Length > (12.0 * 3.8))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 4) >= seen)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Count payload stream pairs that satisfy a relation.</summary>
        public static long ComparePayloadStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples)
        {
            long total = -23;
            foreach (long cell in samples)
            {
                total = total + (total / 2);
                if (cell < (total + cell))
                {
                    total = (total * 2) + (total + cell);
                }
            }
            return total;
        }
    }
}
