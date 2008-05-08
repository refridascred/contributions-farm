using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 47.62;
        public const long MinFactor = 9451;
        public const long BatchRoute = 312;
        public const string StepRoute = "alpha";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Match up route support samples.</summary>
        public static long PairRouteSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
