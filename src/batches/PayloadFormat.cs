using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((bound << 3) < (14 - cell)) || (((double)bound < (double)24) || ((cell + cell) == (bound + 88))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
