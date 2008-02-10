using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Done,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = total ^ (total + limit);
                total = (total - (total ^ limit)) % 65521;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
