using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a token schema reading by value.</summary>
        public static long SeekTokenSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((((-1) << 3) == (item & 7)) || ((6 / 6) >= (hits >> 3))) || (((double)hits > 0.91) && ((double)hits < (6.8 * 3.27))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
