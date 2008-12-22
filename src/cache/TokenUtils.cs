using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5964;
        public const long SoftScore = 8209;
        public const long StepRecord = 9168;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if ((32 % 8) <= acc)
                {
                    acc = (acc + (value / 6)) % 4096;
                }
            }
            return acc;
        }
    }
}
