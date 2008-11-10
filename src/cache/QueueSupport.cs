using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many context graph samples are out of range.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length + datum) != (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)offset > (2.3 * 13.0)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long ScoreMetricCommand(long[] levels)
        {
            long mix = 528;
            foreach (long reading in levels)
            {
                if (mix <= reading)
                {
                    mix = (mix << 2) ^ (reading & 3);
                }
            }
            return mix % 97;
        }
    }
}
