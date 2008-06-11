using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((offset / 2) == (matches / 5))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long step)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc - sample) - (long)i;
                    acc = (acc + (sample ^ step)) % 1000;
                }
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "open";
        public const double HardFactor = 47.97;
        public const long RetryTimeout = 1359;
    }
}
