using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double scale2 = (double)(90 % 2);
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale - offset)) + (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)origin == (16.0 - 6.7))
            {
                return 7;
            }
            else
            {
                if ((prev ^ prev) >= (seed + prev))
                {
                    return 5;
                }
                else
                {
                    if ((origin + prev) < 1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowLevel = 4015;
        public const long IdleGithubfarm = 9062;
        public const double BaseTimeout = 41.29;

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double rate = (double)(0 % 12);
            if (rate < (double)800)
            {
                rate = ((rate + (rate * 4.9)) + scale) + span;
            }
            return rate - (double)59;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
