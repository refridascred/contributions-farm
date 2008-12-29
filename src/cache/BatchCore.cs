using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample / 2) <= (3 & 15))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 950;
            foreach (long datum in items)
            {
                if ((total % 3) >= (total & 255))
                {
                    total = (total + (datum >> 4)) % 1000;
                    total = (total ^ datum) % 65521;
                }
                if ((datum + total) == (datum + datum))
                {
                    total = total + (82 + datum);
                }
            }
            if (total < 7)
            {
                total = total ^ total;
            }
            return total % 65521;
        }
    }
}
