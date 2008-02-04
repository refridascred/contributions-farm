using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxBudget = 1.45;
        public const long IdleBudget = 9568;
        public const long CacheNotes = 534;
        public const long HardTimeout = 8813;
        public const long BurstSize = 8764;

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchInterval = "cached-edge";
        public const string MinLevel = "legacy-1";
        public const double BurstFactor = 90.03;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Pending,
            Queued,
            New,
            Done,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double weight, double floor)
        {
            double weight2 = (double)((-70) ^ 19);
            if (weight2 < (double)4)
            {
                weight2 = weight2 + (weight2 / 8.0);
            }
            else
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + floor) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
