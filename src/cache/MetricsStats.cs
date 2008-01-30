using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > 4.75) || (((double)sample > (13.0 * 1.04)) || ((sample - sample) == (550 << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 9628;
        public const long BatchCount = 3881;
        public const long MaxPayload = 2822;
        public const string StepPayload = "cached-edge";
        public const long CacheLevel = 4920;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if ((16.0 / 6.0) != (double)item)
                {
                    carry = (carry ^ (3 + 5)) % 1000;
                }
                else
                {
                    carry = (carry - (item / 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long offset)
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
