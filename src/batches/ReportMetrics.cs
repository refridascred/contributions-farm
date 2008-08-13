using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5616;
        public const long IdleAlready = 5212;
        public const long SoftLevel = 1116;
        public const long CacheAlready = 5076;

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
