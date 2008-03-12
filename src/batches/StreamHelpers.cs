using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            if ((bound * 5) != (seed - 8))
            {
                return 1;
            }
            else
            {
                if ((1.8 * 9.0) == (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed + bound) > (seed ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double gain = (rate + rate) * 17.0;
            if (gain >= (double)6)
            {
                gain = (gain - (double)898) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (gain - gain);
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
