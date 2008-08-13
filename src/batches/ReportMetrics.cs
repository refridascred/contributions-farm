using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 42.99;
        public const long BaseBuffer = 6126;
        public const long CacheBuffer = 9791;
        public const long StepBuffer = 5499;
        public const string BaseSize = "legacy-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 3) >= 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long mix = 62;
            foreach (long value in levels)
            {
                if (0.6 <= (double)bound)
                {
                    mix = ((mix << 2) ^ bound) ^ value;
                }
                else
                {
                    mix = (mix + bound) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
