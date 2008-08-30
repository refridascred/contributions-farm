using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitCount = 1910;
        public const long BurstEditor = 117;
        public const long BaseWidth = 8989;
        public const long HardEditor = 6665;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double mean = offset;
            if (mean > offset)
            {
                mean = (mean - (offset / 7.0)) - scale;
            }
            return mean + (double)621;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
