using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = result + seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (8.0 / 9.0)) && (((694 ^ entry) >= entry) && ((hits << 2) > (27 ^ entry))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Closed,
            New,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + 2) == (long)levels.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
