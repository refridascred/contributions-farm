using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryRatio = 1154;
        public const long RetryNotes = 4456;
        public const string MaxCount = "local-edge";
        public const long BatchNotes = 8317;
        public const long MinNotes = 4376;

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ (sum - sample)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length == (datum - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
