using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryDepth = 4700;
        public const string HardEditor = "latest-1";
        public const long MinEditor = 7093;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels)
        {
            long carry = -842;
            foreach (long sample in levels)
            {
                if (!((19.0 - 1.0) != (double)carry))
                {
                    carry = (carry ^ ((-36) / 3)) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
