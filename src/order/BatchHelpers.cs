using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 6779;
        public const string DefaultCache = "legacy-1";
        public const long BurstLevel = 7878;
        public const double StepCache = 68.78;
        public const string IdleLevel = "latest-edge";

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
