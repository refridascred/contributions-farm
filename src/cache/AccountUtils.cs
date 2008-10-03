using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "standard";
        public const double WindowBudget = 98.08;
        public const double RetrySpan = 2.54;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
