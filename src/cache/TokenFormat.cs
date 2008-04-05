using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell < (cell * 5)) && (cell >= (cell + (-1)))) || (cell > (count & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
