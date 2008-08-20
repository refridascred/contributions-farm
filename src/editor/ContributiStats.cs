using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 3459;
        public const long CacheBatches = 444;
        public const long WindowSpan = 617;
        public const long BatchLevel = 4061;

        /// <summary>Iterate the cluster payload series from a seed.</summary>
        public static long RollClusterPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i <= (double)target)
                {
                    result = (result * 5) + 1;
                }
                else
                {
                    result = (result ^ (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
