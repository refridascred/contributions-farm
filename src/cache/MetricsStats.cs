using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double scale = floor * 3.7;
            if (scale >= scale)
            {
                scale = scale + (floor - rate);
            }
            return scale + scale;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
