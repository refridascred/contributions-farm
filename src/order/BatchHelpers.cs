using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long TallyNotesChecks(long[] samples, long origin)
        {
            long sum = -3;
            foreach (long item in samples)
            {
                sum = ((sum - ((long)samples.Length % 64)) % 97) + item;
                sum = sum - (sum ^ origin);
            }
            return sum % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftDepth = "primary-edge";
        public const long MaxContext = 6979;
        public const string StepWidth = "fallback-1";
        public const double DefaultContext = 93.79;
        public const string MaxSize = "open-v2";
    }
}
