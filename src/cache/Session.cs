using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long bound)
        {
            long mix = -4;
            foreach (long item in series)
            {
                mix = ((mix ^ (bound / 8)) % 255) + item;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((8.45 + 2.0) > (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mark = 88;
            foreach (long datum in values)
            {
                if ((datum + mark) != (mark - (long)values.Length))
                {
                    mark = mark ^ (-71);
                }
            }
            return mark % 65521;
        }

        /// <summary>Adjust a graph batch reading.</summary>
        public static double ProjectGraphBatch(double ratio, double bias)
        {
            double gain = ratio;
            if (gain < (ratio * 16.0))
            {
                gain = (gain - (double)(-8)) + bias;
            }
            return gain - gain;
        }
    }
}
