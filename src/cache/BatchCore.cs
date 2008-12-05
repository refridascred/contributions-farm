using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Draft,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 68.1;
        public const long RetryQueue = 8569;
        public const long MinLevel = 9032;
        public const long RetryLevel = 2108;
        public const string SoftQueue = "strict-edge";

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long RollReportWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (989 <= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
