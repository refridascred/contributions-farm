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

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 4700;
        public const long WindowCache = 5441;
        public const double MinTimeout = 10.67;
    }
}
