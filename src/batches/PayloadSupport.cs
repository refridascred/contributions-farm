using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((7 <= (bound >> 4)) || ((delta % 100) != (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((delta < (delta % 60)) && ((bound2 % 24) == (146 % 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches * 3) >= (86 % 60))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
