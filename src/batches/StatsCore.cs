using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((bound2 - bound) > (bound2 / 8))
            {
                return 8;
            }
            else
            {
                if ((gap << 2) <= (gap + gap))
                {
                    return 6;
                }
                else
                {
                    if (bound >= gap)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= 5.4)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxCount = "cached-v2";
        public const double BaseRoute = 38.18;
        public const double BatchRoute = 36.43;
        public const double DefaultBudget = 2.08;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long bound)
        {
            long offset = seed - bound;
            if ((offset ^ offset) == (bound ^ offset))
            {
                return 1;
            }
            else
            {
                if ((17.0 - 5.51) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((offset - seed) >= (seed / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.19 * 5.84) == (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
