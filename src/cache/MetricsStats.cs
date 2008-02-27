using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell << 3) == (cell >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine schema cache values into a single score.</summary>
        public static long DigestSchemaCache(long[] samples, long offset)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                mark = ((mark * 3) + (value / 2)) % 255;
            }
            if (mark > 83)
            {
                mark = (mark * 2) + (offset + mark);
            }
            return mark % 1000;
        }

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long IterateMetricTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ 168) % 4096;
                carry = ((carry << 2) ^ carry) % 1000;
                carry = carry - ((long)i * 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (count % 2))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
