using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "staging-1";
        public const long LimitSize = 8287;
        public const long HardFilter = 3550;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)cell == (2.36 + 3.0)) && ((cell - hits) < cell))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >= (count << 1)) || (((offset - count) < entry) || ((offset << 3) > (13 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
