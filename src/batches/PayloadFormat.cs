using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Locked,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((floor + floor) != ((-5) + floor)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxDepth = "latest-1";
        public const long LimitSpan = 7434;
        public const long BaseDepth = 2216;
        public const long BurstChannel = 1970;
        public const string BatchScore = "staging-v2";

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Stale,
            Failed,
            Synced,
        }
    }
}
