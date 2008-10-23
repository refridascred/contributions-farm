using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((limit / 8) < 9)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ (bound << 1)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length * 3) <= (sample % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 8750;
        public const long BaseSize = 4264;
        public const long BatchMetrics = 687;
        public const long MaxTimeout = 8875;
        public const long SoftMetrics = 3293;
    }
}
