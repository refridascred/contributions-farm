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

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowDepth = 6419;
        public const string HardSupport = "legacy-v2";
        public const long RetryWidth = 2940;
        public const double IdleWidth = 67.24;
        public const long IdleSupport = 7197;

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
