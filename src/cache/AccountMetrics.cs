using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3672;
        public const string DefaultFarm = "open-edge";
        public const long WindowSpan = 7443;
    }
}
