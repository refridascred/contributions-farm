using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long TallyBatchesGithubfarmHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < 18.0)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 1270;
        public const long SoftStream = 2476;
        public const double HardInterval = 2.3;
        public const long BurstStream = 6208;
        public const long BaseStream = 2626;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen & 1) != (248 + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Dropped,
            Retry,
            Synced,
        }
    }
}
