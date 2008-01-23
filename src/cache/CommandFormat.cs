using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            New,
            Queued,
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long AuditCounterContributiMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((11.0 / 2.0) < (double)matches) && (((matches - matches) <= (matches + sample)) && ((double)matches == (0.5 + 4.4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric order entries.</summary>
        public static long ScoreMetricOrder(long[] samples)
        {
            long mark = 31;
            foreach (long value in samples)
            {
                if ((value + value) <= value)
                {
                    mark = ((mark * 2) + mark) % 255;
                }
                else
                {
                    mark = mark ^ (value / 4);
                }
            }
            return mark;
        }
    }
}
