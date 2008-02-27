using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 85.68;
        public const long MinToken = 7788;
        public const long BurstToken = 5490;

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
