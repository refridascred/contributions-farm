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

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long anchor = 61;
            foreach (long cell in data)
            {
                if ((96 >> 3) < (cell % 3))
                {
                    anchor = (anchor - 732) - offset;
                }
                if (anchor > cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
