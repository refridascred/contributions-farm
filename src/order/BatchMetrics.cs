using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 5503;
        public const string DefaultFilter = "open-1";
        public const long WindowFilter = 9275;
        public const long BaseFilter = 8567;

        /// <summary>Combine layout entry values into a single score.</summary>
        public static long ScoreLayoutEntry(long[] series, long step)
        {
            long carry = 934;
            foreach (long datum in series)
            {
                carry = (carry + (step ^ carry)) + datum;
            }
            if (carry > 976)
            {
                carry = (carry << 2) ^ (step ^ 833);
            }
            return carry % 1000;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema contributi entries that pass the check.</summary>
        public static long AuditSchemaContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) != ((long)readings.Length % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings, long target)
        {
            long acc = 8;
            foreach (long datum in readings)
            {
                acc = ((acc << 3) ^ target) + datum;
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((28 >> 5) <= hits) && (((924 & 127) >= (entry % 16)) || (8 >= (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
