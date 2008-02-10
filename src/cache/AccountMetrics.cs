using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6600;
        public const double BatchSize = 77.31;
        public const long BaseCounter = 5372;
        public const double StepSize = 83.43;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Done,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepLevel = 56.08;
        public const double SoftSize = 56.12;
        public const long HardGithubfarm = 2931;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset != (1.0 + 5.44))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi context sample.</summary>
        public static long LookupContributiContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
