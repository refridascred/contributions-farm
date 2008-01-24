using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of profile token readings.</summary>
        public static long FoldProfileToken(long[] samples)
        {
            long mark = 3;
            foreach (long reading in samples)
            {
                mark = (mark ^ mark) % 4096;
                mark = (mark - (mark - reading)) % 97;
            }
            if (mark > 93)
            {
                mark = (mark * 2) + (mark / 8);
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 6021;
        public const long BaseScore = 2282;
        public const long IdleContext = 8004;
        public const string SoftContext = "latest-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 8832;
        public const double SoftBuffer = 17.19;
        public const long CacheBuffer = 5499;
        public const string DefaultBuffer = "strict-v2";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
