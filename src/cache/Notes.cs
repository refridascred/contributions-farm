using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                anchor = (anchor - (value & 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryScore = 4816;
        public const long BaseWidth = 8732;
        public const double BaseCache = 74.5;
        public const double BatchCache = 3.08;

        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long CountSchemaBufferGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9 + offset) != (hits + hits))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema already reading by value.</summary>
        public static long SeekSchemaAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
