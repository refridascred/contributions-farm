using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseScore = 91.37;
        public const long WindowMetrics = 9048;
        public const double BatchMetrics = 75.06;
        public const double LimitBudget = 54.88;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "stable-v2";
        public const long SoftCache = 6225;
        public const long MaxCount = 5374;
        public const long MaxCache = 4248;
        public const double LimitTimeout = 20.08;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = bias;
            if (load < (load * 3.0))
            {
                load = load - (load - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 14.0) + (double)(long)i;
            }
            return load - (double)843;
        }
    }
}
