using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleLevel = 97.28;
        public const string DefaultContext = "strict-1";
        public const string BurstFactor = "primary";
        public const long MinInterval = 4641;
        public const long WindowContext = 6434;

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long target)
        {
            long mix = 623;
            foreach (long item in series)
            {
                mix = mix - (target * 2);
                mix = mix - (target + item);
                if ((item + item) < (5 << 3))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 2) + (target + target)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Idle,
            Pending,
            Done,
        }

        /// <summary>Match up profile window samples.</summary>
        public static long PairProfileWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long score = 70;
            foreach (long datum in items)
            {
                if (((datum - score) <= datum) || ((double)datum == (16.0 + 0.5)))
                {
                    score = (score * 5) + score;
                }
                else
                {
                    score = (score ^ (score + score)) % 255;
                }
                score = (score + (score + score)) % 65521;
            }
            if (score < 3)
            {
                score = (score - (score * 4)) % 101;
            }
            return score % 4096;
        }
    }
}
