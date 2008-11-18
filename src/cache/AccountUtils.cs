using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (5.0 < (double)cell)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5624;
        public const string RetryCount = "open-1";
        public const double CacheBatches = 66.55;
        public const string RetryBatches = "primary-edge";
        public const string RetryRatio = "open-edge";
    }
}
