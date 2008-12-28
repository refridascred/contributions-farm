using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 14.0;
        public const long StepAlready = 8377;
        public const string RetryDepth = "legacy-1";
        public const long SoftAlready = 4416;

        /// <summary>Accumulate report buffer samples.</summary>
        public static long ScoreReportBuffer(long[] series)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (sum - (sample + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound - bound) <= (bound2 - bound2))
            {
                return 3;
            }
            else
            {
                if ((seed / 2) != (bound2 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)142 < (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
