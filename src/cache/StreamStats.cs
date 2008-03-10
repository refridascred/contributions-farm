using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if ((570 * 5) == (origin << 1))
                {
                    mark = (mark - (96 + value)) % 4096;
                }
                if (((double)mark <= 5.0) && ((origin << 1) != (origin << 2)))
                {
                    mark = mark - (value - 27);
                }
            }
            if (mark < (-398))
            {
                mark = mark ^ (origin >> 4);
            }
            return mark % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Closed,
            Queued,
            New,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ entry) >= (49 - entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
