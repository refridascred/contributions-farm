using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 321;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + item) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 8975;
        public const double RetryRatio = 12.55;
        public const double StepDepth = 67.96;
        public const long LimitScore = 1527;
        public const long HardScore = 5841;

        /// <summary>Fold a list of already stats readings.</summary>
        public static long TallyAlreadyStats(long[] levels, long step)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (step & 3)) % 65521) + datum;
            }
            if (mark > 6)
            {
                mark = (mark - (step + step)) % 101;
            }
            return mark % 65521;
        }
    }
}
