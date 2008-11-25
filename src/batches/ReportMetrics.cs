using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 48.25;
        public const long RetryScore = 798;
        public const string LimitRatio = "primary-1";
        public const long LimitWidth = 5450;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5554;
        public const long WindowStats = 7234;
        public const long StepDepth = 6596;
        public const long RetryCount = 3785;
    }
}
