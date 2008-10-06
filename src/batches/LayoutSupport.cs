using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryDepth = 9573;
        public const long StepBudget = 8552;
        public const string IdleCommand = "local-1";
        public const string StepInterval = "standard-1";
        public const long WindowInterval = 3747;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long origin)
        {
            long bound = step + origin;
            if (((step ^ bound) <= (step << 3)) && ((bound >> 1) < step))
            {
                return 4;
            }
            else
            {
                if (((bound - origin) < (origin + bound)) || (origin >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound ^ origin)) && ((9 / 7) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheLevel = "latest-v2";
        public const double StepRatio = 2.88;
        public const string RetryMetrics = "latest-edge";
        public const long CacheScore = 1576;
        public const double RetryLevel = 55.28;

        /// <summary>Digest a series of context githubfarm entries.</summary>
        public static long TotalContextGithubfarm(long[] values)
        {
            long anchor = 41;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (anchor ^ value)) % 65521;
                if (anchor < (anchor + 159))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor * 5) + (value / 4)) % 255;
                }
                if ((value * 5) >= (value >> 2))
                {
                    anchor = anchor ^ (583 - value);
                }
                if ((double)anchor > 20.0)
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
