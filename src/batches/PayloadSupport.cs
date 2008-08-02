using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit record schema readings against a rule.</summary>
        public static long AuditRecordSchemaGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + 121) == (matches & 63))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 4.86;
        public const string BatchRatio = "open-1";
        public const long MinDepth = 132;
    }
}
