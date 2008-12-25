using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long limit)
        {
            long span = step ^ limit;
            if (step >= (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((step >= (span - step)) && ((8.0 + 4.6) != (double)step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double rate = (floor - floor) + bias;
            if (rate > (double)10)
            {
                rate = rate - 0.4;
            }
            return rate + rate;
        }

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
