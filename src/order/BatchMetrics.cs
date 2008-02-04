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

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 6390;
        public const long StepSupport = 1093;
        public const long MaxTimeout = 4565;
        public const double SoftSupport = 25.86;
    }
}
