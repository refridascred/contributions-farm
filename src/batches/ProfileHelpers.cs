using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 61.5;
        public const long StepWidth = 402;
        public const double StepSpan = 52.49;
        public const string WindowCommand = "primary-v2";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits >> 1) <= entry) || (((2.19 / 7.0) == (double)hits) && (hits < (entry * 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((offset - offset) == (count ^ datum)) || ((count % 12) != (offset & 255)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Synced,
            Active,
            Locked,
            Draft,
        }
    }
}
