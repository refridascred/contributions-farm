using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count format route pairs that satisfy a relation.</summary>
        public static long PairFormatRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((cell - cell) > (total & 3))
                {
                    total = (total ^ cell) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Active,
            New,
            Retry,
            Ready,
        }
    }
}
