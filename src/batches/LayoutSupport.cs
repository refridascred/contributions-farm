using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine order metrics values into a single score.</summary>
        public static long FoldOrderMetrics(long[] data, long seed)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (!((double)seed == (4.8 / 5.0)))
                {
                    mark = ((mark - (seed - seed)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark - 2) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark - (69 / 8);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long CountChecksContextMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (offset ^ offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double ratio = rate;
            if (ratio < (20.0 / 5.0))
            {
                ratio = (ratio - rate) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
