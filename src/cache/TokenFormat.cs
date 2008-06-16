using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (4.6 > (double)limit)
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a token counter reading by value.</summary>
        public static long FindTokenCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
