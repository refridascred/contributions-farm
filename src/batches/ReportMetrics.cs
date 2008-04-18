using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Active,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 4570;
        public const long BatchAlready = 2756;
        public const string SoftRatio = "standard-v2";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((2.7 - 2.0) != (double)anchor)
                {
                    anchor = ((anchor * 2) + (anchor - (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
