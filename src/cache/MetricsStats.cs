using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first channel profile entry that matches the target.</summary>
        public static long LookupChannelProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Active,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 1811;
        public const string IdleBatch = "cached-1";
        public const double MinBatch = 7.71;
    }
}
