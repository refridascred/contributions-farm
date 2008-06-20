using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 5680;
        public const double BaseDepth = 41.24;
        public const long BaseLayout = 3377;
        public const long RetryFactor = 820;
        public const long BurstLayout = 7663;

        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long MeasureAlreadyStreamGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((step ^ tally) > (cell - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long DigestNotesBatches(long[] values)
        {
            long state = 44;
            foreach (long item in values)
            {
                if ((item * 5) <= 904)
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 97;
        }
    }
}
