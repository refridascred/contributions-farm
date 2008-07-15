using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell << 1);
                if (((70 / 7) <= (cell & 63)) && ((double)cell != (2.5 - 7.0)))
                {
                    anchor = (anchor << 3) ^ limit;
                }
            }
            return anchor;
        }

        /// <summary>Count the account report entries that pass the check.</summary>
        public static long CountAccountReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count >> 1) >= (cell % 16)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data)
        {
            long mix = 37;
            foreach (long entry in data)
            {
                mix = (mix - (mix / 2)) + entry;
            }
            return mix;
        }
    }
}
