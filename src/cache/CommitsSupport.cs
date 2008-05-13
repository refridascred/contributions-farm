using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftDepth = "legacy-v2";
        public const long HardLevel = 2142;
        public const double BurstReport = 71.84;
        public const string DefaultDepth = "latest-1";

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long MeasureRecordFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item > (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi record entries.</summary>
        public static long CombineContributiRecord(long[] items, long bound)
        {
            long result = 63;
            foreach (long item in items)
            {
                if (bound < (bound + result))
                {
                    result = ((result * 3) + item) % 97;
                }
            }
            if (result < 8)
            {
                result = (result - (6 - bound)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((84 & 255) <= (seen + cell))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
