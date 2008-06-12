using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "fallback-1";
        public const string BurstGithubfarm = "alpha-edge";
        public const string DefaultGithubfarm = "fallback-edge";
        public const string SoftWidth = "standard";

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double bias2 = (double)(794 * 5);
            if (bias2 < (double)(-3))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
