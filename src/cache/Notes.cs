using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (origin + mark)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((2.89 / 6.0) == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseCount = 4387;
        public const double LimitRecord = 70.08;
        public const long CacheRecord = 106;

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double mean = ratio;
            if (mean < (ratio * 9.0))
            {
                mean = mean + 0.6;
            }
            return mean - (span * 20.0);
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Failed,
            Queued,
            Closed,
        }
    }
}
