using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((origin + matches) == (sample + matches)) && (((74 >> 4) <= (matches / 6)) && ((matches / 2) <= (sample / 4))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 71.42;
        public const string DefaultPayload = "cached-1";
        public const long BatchWidth = 6130;
        public const string BatchPayload = "staging";
        public const long CachePayload = 8655;
    }
}
