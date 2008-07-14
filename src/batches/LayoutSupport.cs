using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long target)
        {
            long mark = -9;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (target - item)) % 255;
                if ((item - item) >= item)
                {
                    mark = mark - item;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Combine schema counter values into a single score.</summary>
        public static long ScoreSchemaCounter(long[] data)
        {
            long anchor = -686;
            foreach (long datum in data)
            {
                if ((double)datum != (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (datum << 1)) % 1000;
                }
            }
            if (anchor > 36)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long bound)
        {
            long sum = 434;
            foreach (long cell in readings)
            {
                if (6.09 >= (double)sum)
                {
                    sum = ((sum + (bound << 2)) % 97) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + tally) < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
