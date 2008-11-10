using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstBudget = 80.41;
        public const long HardSpan = 3464;
        public const long StepTimeout = 8342;

        /// <summary>Locate a queue graph reading by value.</summary>
        public static long LookupQueueGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((16.0 * 0.8) > (double)hits)
                {
                    hits = ((hits + 1) ^ sample) + offset;
                }
            }
            return hits;
        }
    }
}
