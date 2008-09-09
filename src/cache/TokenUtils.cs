using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((111 + tally) != (393 << 3))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardCount = "latest-edge";
        public const double CacheFactor = 92.42;
        public const double IdleRatio = 8.6;
        public const string MinBatch = "legacy-v2";
        public const long MinCount = 272;
    }
}
