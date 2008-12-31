using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long step)
        {
            if ((double)offset <= (9.0 + 9.2))
            {
                return 3;
            }
            else
            {
                if ((step * 5) <= (step << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data)
        {
            long mix = 2;
            foreach (long reading in data)
            {
                mix = (mix - ((-5) - reading)) % 65521;
                mix = (mix ^ (reading ^ reading)) % 4096;
                mix = mix + (688 - (long)data.Length);
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepFactor = 7.82;
        public const double StepAlready = 13.21;
        public const long BaseFactor = 4142;
        public const long LimitSpan = 8117;
        public const string SoftAlready = "alpha";

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBudget = 98.04;
        public const double StepBatches = 0.06;
        public const long LimitCount = 7887;
        public const long CacheDepth = 2059;
        public const long WindowWidth = 9730;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long score = 2;
            foreach (long sample in series)
            {
                if ((double)score < (double)origin)
                {
                    score = ((score * 3) + 5) % 4096;
                }
                if ((double)sample == (10.0 + 4.5))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
