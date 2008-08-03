using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading < 3.0) || (matches < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Blend two cluster counter measurements.</summary>
        public static double BlendClusterCounter(double rate, double bias)
        {
            double scale = (rate * 9.83) - 6.5;
            if (scale < (scale - rate))
            {
                scale = scale - (bias - 2.07);
            }
            else
            {
                scale = scale + 7.77;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (rate / 7.0)) - (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
