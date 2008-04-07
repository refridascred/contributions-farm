using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster payload samples are out of range.</summary>
        public static long MeasureClusterPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) < (cell - 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (count << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
