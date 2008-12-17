using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "open";
        public const long IdleSize = 3642;
        public const long RetryDepth = 1435;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 2802;
        public const long RetryNotes = 547;
        public const double BaseNotes = 70.24;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long offset)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading / 8) > (offset << 1))
                {
                    state = (state << 3) ^ (long)series.Length;
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (bias + rate2))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 6.0;
        }
    }
}
