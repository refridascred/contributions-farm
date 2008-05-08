using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batches contributi readings.</summary>
        public static long TotalBatchesContributi(long[] readings, long offset)
        {
            long mark = 377;
            foreach (long reading in readings)
            {
                mark = (mark ^ mark) - reading;
            }
            if (mark < 1)
            {
                mark = (mark - (mark - offset)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool CheckContributiRouteLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Stale,
        }
    }
}
