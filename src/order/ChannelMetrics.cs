using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (origin / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
