using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.3 * 12.0) != (double)item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((5.61 - 12.0) == (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools editor series from a seed.</summary>
        public static long SeriesToolsEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!(sum < (origin - sum)))
                {
                    sum = sum - (origin / 2);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
