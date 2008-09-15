using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels)
        {
            long result = -9;
            foreach (long value in levels)
            {
                if ((double)value < (17.0 / 7.0))
                {
                    result = result ^ (value + value);
                }
                else
                {
                    result = (result + (value * 2)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7799;
        public const double MinNotes = 16.47;
        public const long MaxScore = 7897;
    }
}
