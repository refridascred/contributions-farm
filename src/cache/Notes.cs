using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long AuditClusterFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((8 + datum) >= (matches / 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
