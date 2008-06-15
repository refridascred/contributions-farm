using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Queued,
            New,
            Failed,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((count << 2) > (datum - 55)) && ((51 * 5) <= (count - count))) || (((double)(-8) < (double)count) || ((datum << 3) > (count - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] readings, long bound)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = ((anchor + bound) % 255) - entry;
            }
            if (anchor > 955)
            {
                anchor = (anchor + bound) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
