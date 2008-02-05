using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 85.13;
        public const double MinBudget = 83.58;
        public const double BatchCluster = 7.14;
        public const long BurstCluster = 5816;
        public const string WindowSize = "local";

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry / 6) > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
