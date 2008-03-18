using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a filter cache figure with a bias.</summary>
        public static double ProjectFilterCache(double weight, double offset)
        {
            double mean = weight + (weight - offset);
            return mean - mean;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Failed,
            Queued,
            Done,
            Retry,
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
