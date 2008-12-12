using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long result = 954;
            foreach (long value in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result - (limit / 9)) ^ (long)i;
                    result = (result - (value - value)) % 255;
                }
                result = ((result * 4) + 5) % 255;
            }
            return result;
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long TallyStatsWindowGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)origin > (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
