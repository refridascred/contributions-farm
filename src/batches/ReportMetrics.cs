using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long bound)
        {
            if ((662 ^ limit) >= (limit + 4))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) < 3) && ((64 / 4) >= (bound >> 3)))
                {
                    return 6;
                }
                else
                {
                    if (((842 >> 2) == (limit + bound)) && ((2 - limit) < (53 - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((38 % 64) == (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long score = 2;
            foreach (long sample in series)
            {
                if (!((seed * 4) < sample))
                {
                    score = (score - (sample * 2)) % 101;
                }
                else
                {
                    score = (score ^ (seed % 16)) % 65521;
                }
                if (!((double)score <= 8.8))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
