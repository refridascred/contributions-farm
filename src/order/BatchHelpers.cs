using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits ^ hits) > hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long origin)
        {
            long acc = 57;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (62 + origin)) % 101) + cell;
                acc = (acc * 2) + (acc + 95);
            }
            return acc;
        }
    }
}
