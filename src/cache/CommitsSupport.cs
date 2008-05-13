using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long origin)
        {
            if ((8.0 / 7.0) != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((3.6 + 3.41) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((11 % 97) >= (origin / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin & 7) < (offset - (-54))))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Dropped,
            Stale,
            New,
        }
    }
}
