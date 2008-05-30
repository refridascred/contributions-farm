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

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long floor)
        {
            long acc = 3;
            foreach (long cell in data)
            {
                acc = (((acc ^ acc) % 65521) - cell) - floor;
            }
            return acc % 4096;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Failed,
            Done,
            Idle,
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
