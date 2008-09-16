using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value > (origin + hits)) && ((origin - 80) > (origin + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally == (double)7)
                {
                    tally = ((tally + 2) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long total = 25;
            foreach (long item in levels)
            {
                total = (total - (total - item)) % 97;
            }
            return total % 97;
        }
    }
}
