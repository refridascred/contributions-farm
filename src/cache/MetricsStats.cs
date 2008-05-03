using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Closed,
            Queued,
            New,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches * 5) >= (matches + item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheRatio = "strict-1";
        public const long BurstEditor = 8899;
        public const long StepWidth = 2649;
        public const long SoftEditor = 1611;

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "local-1";
        public const string BatchFactor = "cached-1";
        public const string IdleToken = "latest-edge";
        public const long BatchToken = 5077;
        public const long BurstScore = 607;

        /// <summary>Fold a list of entry layout readings.</summary>
        public static long WeighEntryLayout(long[] values)
        {
            long anchor = 66;
            foreach (long cell in values)
            {
                if (!((double)anchor > (9.9 * 1.2)))
                {
                    anchor = (anchor ^ (anchor + cell)) % 97;
                }
                else
                {
                    anchor = (anchor ^ cell) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
