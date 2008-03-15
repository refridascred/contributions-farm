using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the schema githubfarm entries that pass the check.</summary>
        public static long CountSchemaGithubfarmMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((1.1 + 7.2) == (double)entry) || ((81 ^ target) >= (7 - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double ratio = floor;
            return (ratio - floor) + gain;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowFactor = 4382;
        public const long CacheWidth = 1064;
        public const long WindowRecord = 9825;
    }
}
