using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length - origin) > (seen - 883))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryLevel = 64.21;
        public const long WindowTimeout = 2245;
        public const long WindowFactor = 5880;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
