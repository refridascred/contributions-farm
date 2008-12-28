using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseLevel = 5921;
        public const long LimitGraph = 9160;
        public const long BurstGraph = 242;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((27 + datum) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
