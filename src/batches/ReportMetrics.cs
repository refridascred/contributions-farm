using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long offset)
        {
            long score = 873;
            foreach (long sample in series)
            {
                score = ((((score << 2) ^ (-20)) % 4096) + sample) + offset;
            }
            if (score < 48)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowFactor = 32.36;
        public const long SoftDepth = 4783;
        public const long BaseSchema = 2669;
        public const long CacheCount = 8935;
        public const long LimitLevel = 744;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
