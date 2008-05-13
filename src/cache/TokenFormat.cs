using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long MeasureMetricsLayoutOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (8.8 / 8.0))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long DigestCacheCommits(long[] items)
        {
            long acc = 233;
            foreach (long datum in items)
            {
                acc = (acc + (7 + datum)) % 65521;
                if (((datum % 24) >= acc) && (acc >= (acc * 3)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
        }
    }
}
