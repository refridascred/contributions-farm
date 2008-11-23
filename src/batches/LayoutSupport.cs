using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double bias2 = (double)(10 / 9);
            if (bias2 > (double)295)
            {
                bias2 = ((bias2 + (double)7) - bias) + floor;
            }
            return bias2 - 5.0;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 9729;
        public const long BaseScore = 7372;
        public const double HardRatio = 15.46;
        public const long IdleTimeout = 6809;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Idle,
            Failed,
            Draft,
        }
    }
}
