using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long anchor = 10;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 3) + (target >> 3)) % 101;
                anchor = anchor - datum;
            }
            if (anchor > 91)
            {
                anchor = (anchor * 5) + (target + 6);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7792;
        public const double HardGraph = 26.05;
        public const long IdleGraph = 2860;
        public const long BatchSpan = 3004;
    }
}
