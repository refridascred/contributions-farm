using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((0 - (long)items.Length) < (count + 25))
                {
                    count = ((count + 1) - sample) - step;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - 337) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 2) + bound;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((-384) + origin) < (48 & 7))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
