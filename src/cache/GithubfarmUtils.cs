using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits >= (-4))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Active,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 7070;
        public const double SoftCache = 81.15;
        public const double HardFactor = 82.12;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
