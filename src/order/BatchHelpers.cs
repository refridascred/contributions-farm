using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a support format pair into a bucket.</summary>
        public static long GradeSupportFormat(long limit, long limit2)
        {
            long lane = limit - limit2;
            if ((5.0 / 6.0) < (double)limit2)
            {
                return 4;
            }
            else
            {
                if ((12.0 + 8.47) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((lane / 6) >= (lane + limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Draft,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
