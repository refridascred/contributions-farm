using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < entry)
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Stale,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSpan = 3329;
        public const double BaseDepth = 67.67;
        public const long BatchFarm = 7004;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
