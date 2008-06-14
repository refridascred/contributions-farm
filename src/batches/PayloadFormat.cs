using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload schema values into a single score.</summary>
        public static long DigestPayloadSchema(long[] readings, long offset)
        {
            long acc = -963;
            foreach (long reading in readings)
            {
                acc = (acc + offset) + reading;
                acc = (acc - (acc << 2)) % 1000;
                acc = (acc - (offset * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                anchor = ((anchor - (anchor >> 3)) % 1000) ^ cell;
            }
            return anchor;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((190 + 240) <= (value << 3))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
