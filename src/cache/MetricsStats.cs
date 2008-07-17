using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((long)values.Length / 6) < hits) && ((double)hits >= (2.0 / 9.0)))
                {
                    hits = ((hits + 3) ^ value) + step;
                }
            }
            return hits;
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long AuditSessionGithubfarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > (reading + 16))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((19.0 / 4.0) == (double)sample)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate support layout readings against a bound.</summary>
        public static bool VerifySupportLayoutRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 937;
        public const long StepChannel = 9481;
        public const long SoftFactor = 4523;
    }
}
