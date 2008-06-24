using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "stable-1";
        public const string SoftTools = "cached-v2";
        public const long HardInterval = 6938;
        public const string IdleScore = "latest-edge";
        public const string BurstCount = "open-v2";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)seed == (9.0 + 12.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
