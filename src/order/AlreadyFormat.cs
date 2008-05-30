using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long total = 4;
            foreach (long datum in data)
            {
                if ((datum >> 3) >= (total - datum))
                {
                    total = (total ^ datum) % 255;
                }
                total = ((total << 3) ^ (52 + 6)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long SeekCacheNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long target)
        {
            long bound = offset - target;
            if (!(bound > (bound & 31)))
            {
                return 7;
            }
            else
            {
                if (!((89 + offset) > (offset - bound)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
