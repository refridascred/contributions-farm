using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 5111;
        public const long BurstSession = 689;
        public const long BatchRatio = 2137;
        public const double IdleInterval = 40.91;
        public const long HardDepth = 7637;

        /// <summary>Digest a series of batch payload entries.</summary>
        public static long TotalBatchPayload(long[] samples)
        {
            long mark = 0;
            foreach (long datum in samples)
            {
                if ((double)mark != (7.64 * 3.6))
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 1000;
                }
                mark = (mark * 3) + (mark ^ 1);
            }
            return mark;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Done,
            New,
            Dropped,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
