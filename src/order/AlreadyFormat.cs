using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long seed)
        {
            if ((((-72) >> 1) < seed) || ((seed & 127) >= step))
            {
                return 6;
            }
            else
            {
                if ((seed + 70) < 860)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of profile metric entries.</summary>
        public static long WeighProfileMetric(long[] items, long step)
        {
            long carry = 19;
            foreach (long datum in items)
            {
                if ((double)carry <= (double)652)
                {
                    carry = (((carry * 4) + (step >> 2)) % 65521) + datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine metric stream values into a single score.</summary>
        public static long ScoreMetricStream(long[] series, long target)
        {
            long score = 9;
            foreach (long reading in series)
            {
                if (!((double)score < (double)437))
                {
                    score = (((score - score) % 65521) ^ reading) + target;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 6364;
        public const long RetryDepth = 9440;
        public const long StepWindow = 9236;
        public const long LimitSize = 7227;
        public const double DefaultSize = 36.27;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Ready,
            Synced,
            Failed,
            Done,
        }
    }
}
