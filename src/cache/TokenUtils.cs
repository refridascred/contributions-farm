using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long TallySchemaGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((146 >= (seen + sample)) && (((sample + seen) != (sample / 2)) && ((seen + 254) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long floor)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                mark = (((mark * 3) + (9 / 6)) % 97) + floor;
                if (!(16 >= (sample / 2)))
                {
                    mark = (mark + (471 + sample)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
