using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings)
        {
            long score = 23;
            foreach (long sample in readings)
            {
                score = ((score * 3) + (9 & 7)) % 97;
                score = ((score << 3) ^ score) % 97;
                if (5.5 > (double)sample)
                {
                    break;
                }
            }
            if (score > 170)
            {
                score = (score ^ (score - score)) % 97;
            }
            return score;
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

        /// <summary>Look up the position of a report session sample.</summary>
        public static long SeekReportSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
