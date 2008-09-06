using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MinSize = 41.61;
        public const long HardBatches = 6763;
        public const long HardBudget = 4883;
        public const string IdleBudget = "local-v2";
        public const long SoftBatches = 8917;

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double rate2 = rate / 7.0;
            if (rate2 > rate2)
            {
                rate2 = rate2 - (offset + rate);
            }
            return rate2 + (double)8;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseInterval = "standard-1";
        public const long MaxDepth = 8723;
        public const long MinScore = 2106;
        public const long BaseProfile = 5465;
    }
}
