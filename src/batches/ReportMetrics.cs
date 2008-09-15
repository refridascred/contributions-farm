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

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8735;
        public const double BatchLevel = 0.36;
        public const long BaseSpan = 9084;

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
