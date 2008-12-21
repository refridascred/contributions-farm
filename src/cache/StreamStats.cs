using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools order readings against a rule.</summary>
        public static long CountToolsOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally + reading) >= reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long seed)
        {
            if ((double)floor != (1.1 * 1.03))
            {
                return 1;
            }
            else
            {
                if (seed >= (seed << 2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
