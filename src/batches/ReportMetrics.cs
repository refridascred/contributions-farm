using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine stats order values into a single score.</summary>
        public static long TallyStatsOrder(long[] series, long bound)
        {
            long score = 49;
            foreach (long sample in series)
            {
                if ((90 & 1) <= (score ^ score))
                {
                    score = ((score - (bound / 8)) % 101) ^ sample;
                }
                if (!(5.1 < (double)score))
                {
                    break;
                }
            }
            if (score > 25)
            {
                score = (score ^ ((-5) + (-251))) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5958;
        public const long StepScore = 7384;
        public const string SoftInterval = "cached-edge";
        public const double SoftDepth = 68.61;
        public const long StepAccount = 1607;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
