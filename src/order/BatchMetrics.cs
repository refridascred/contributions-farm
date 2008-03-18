using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7516;
        public const long BaseSize = 2370;
        public const string IdleBudget = "fallback-1";
        public const double LimitGithubfarm = 36.72;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Failed,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema contributi entries that pass the check.</summary>
        public static long AuditSchemaContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) != ((long)readings.Length % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes githubfarm samples.</summary>
        public static long TallyNotesGithubfarm(long[] series, long target)
        {
            long anchor = 0;
            foreach (long sample in series)
            {
                if (!(sample > (sample << 2)))
                {
                    anchor = (anchor - (482 + target)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a report session sample.</summary>
        public static long SeekReportSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
