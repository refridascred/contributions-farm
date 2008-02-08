using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 7356;
        public const long RetryCache = 8801;
        public const long StepCache = 7644;
        public const long BurstCount = 6381;
        public const string LimitFactor = "strict-1";

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mark = 55;
            foreach (long datum in series)
            {
                if ((double)mark > (double)datum)
                {
                    mark = (mark << 2) ^ (107 ^ mark);
                }
            }
            if (mark > 24)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}
