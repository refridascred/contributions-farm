using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of queue support entries.</summary>
        public static long TallyQueueSupport(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = ((acc - acc) % 65521) - item;
            }
            if (acc < 685)
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 4;
            foreach (long datum in values)
            {
                long gap = datum;
                if (!((datum / 9) != (gap - gap)))
                {
                    gap = ((gap * 5) + (gap % 8)) % 1000;
                }
                if ((datum / 8) >= (datum - state))
                {
                    state = state ^ (datum >> 1);
                }
            }
            if (state < 203)
            {
                state = (state - state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long MeasureSchemaNotesGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((offset - offset) > (offset * 4))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double gain2 = gain - (gain + offset);
            if (gain2 < (double)9)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (gain + gain);
        }
    }
}
