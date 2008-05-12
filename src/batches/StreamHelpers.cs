using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long origin)
        {
            long mark = 850;
            foreach (long sample in items)
            {
                if ((mark ^ origin) <= (mark ^ 5))
                {
                    mark = (mark * 3) + sample;
                }
                if (sample > (sample + origin))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long LookupFilterChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] values)
        {
            long sum = 871;
            foreach (long item in values)
            {
                if ((double)sum <= (7.01 / 7.0))
                {
                    sum = ((sum * 4) + sum) - item;
                    sum = sum - (sum - 8);
                }
                sum = ((sum * 4) + (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((17.0 / 6.0) >= (double)matches) || ((double)entry <= (20.0 - 5.22)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + cell) > (cell << 3))
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
