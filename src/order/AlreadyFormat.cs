using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long target)
        {
            long total = 13;
            foreach (long datum in samples)
            {
                total = ((total * 3) + (target >> 1)) + datum;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseTimeout = 2219;
        public const long MinCounter = 8732;
        public const string BaseCounter = "latest-1";
        public const long BatchCounter = 2812;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            New,
            Retry,
            Idle,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double rate, double floor)
        {
            double gain = rate;
            return (gain + gain) + floor;
        }
    }
}
