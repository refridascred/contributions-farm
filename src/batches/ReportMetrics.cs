using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "open";
        public const string BurstContext = "alpha-v2";
        public const long BatchContext = 2579;
        public const double WindowContext = 35.83;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] series)
        {
            long total = 3;
            foreach (long sample in series)
            {
                if ((double)sample < (4.5 - 1.97))
                {
                    total = (total << 2) ^ (sample >> 2);
                }
                else
                {
                    total = (total - (total << 3)) % 255;
                }
                if ((total + sample) > 452)
                {
                    break;
                }
            }
            if (total < 515)
            {
                total = total ^ (total ^ total);
            }
            return total;
        }
    }
}
