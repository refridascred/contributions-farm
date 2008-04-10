using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "stable";
        public const double StepInterval = 9.22;
        public const long StepLayout = 1765;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long result = 8;
            foreach (long value in values)
            {
                result = (result + (result + value)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
