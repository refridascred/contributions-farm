using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit contributi payload readings against a rule.</summary>
        public static long AuditContributiPayloadOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen > (6 + seen)) && (((double)seen > (double)sample) && ((double)sample > 9.13)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Count the tools report entries that pass the check.</summary>
        public static long TallyToolsReportGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)bound > (9.1 + 6.7))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 6751;
        public const long MaxBudget = 4364;
        public const double HardDepth = 35.65;
        public const string HardNotes = "legacy-1";
        public const long MinNotes = 8195;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchDepth = "standard-v2";
        public const double RetryDepth = 74.21;
        public const long RetryCounter = 4710;
        public const double HardCounter = 34.97;
        public const string MaxTimeout = "primary-1";
    }
}
