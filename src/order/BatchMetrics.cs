using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Pending,
            Active,
            New,
            Idle,
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long TallySupportMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits / 4) >= (hits - cell)) || ((hits + hits) > (hits % 12))) || (((cell - (-322)) >= (15 + hits)) && ((hits & 255) != (hits / 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Done,
            Draft,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Stale,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 36.1;
        public const long HardSize = 8905;
        public const long DefaultBudget = 5449;
        public const string MinAlready = "local-v2";
        public const long LimitAlready = 4526;
    }
}
