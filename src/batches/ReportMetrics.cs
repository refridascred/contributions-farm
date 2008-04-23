using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long origin)
        {
            long carry = 1;
            foreach (long item in items)
            {
                carry = ((carry - (item << 2)) % 255) + origin;
                if ((12.0 > (double)item) && (((-7) ^ carry) >= (item * 4)))
                {
                    carry = (carry ^ 85) % 4096;
                }
                else
                {
                    carry = (carry << 2) ^ (item - 1);
                }
            }
            if (carry > 0)
            {
                carry = (carry - (carry / 4)) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i - total) <= total)
                {
                    total = (total - (88 + total)) % 101;
                }
                if ((total + 41) < origin)
                {
                    total = (total << 2) ^ total;
                    break;
                }
                total = ((total * 5) + (total - origin)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
