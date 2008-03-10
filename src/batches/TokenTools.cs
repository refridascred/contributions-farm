using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)origin > (1.15 * 17.0)) && ((double)(long)items.Length > (8.25 / 9.0)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
