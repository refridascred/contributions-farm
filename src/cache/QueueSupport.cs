using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 760;
        public const string BurstRatio = "staging-v2";
        public const string RetryInterval = "legacy";

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long score = 538;
            foreach (long datum in levels)
            {
                if (!(datum >= (score & 3)))
                {
                    score = score + score;
                }
                else
                {
                    score = (score ^ score) % 97;
                }
            }
            if (score < 7)
            {
                score = ((score * 2) + (score >> 2)) % 101;
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (((mark * 3) + seed) % 255) - sample;
            }
            return mark;
        }
    }
}
