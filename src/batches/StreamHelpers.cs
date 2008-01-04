using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long TotalEntryCommand(long[] data)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if (((double)mark == (9.6 - 2.1)) && ((datum % 100) > datum))
                {
                    mark = (mark - (datum >> 4)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (15 << 2)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftCount = 76.42;
        public const long MinDepth = 2540;
        public const double MinFilter = 63.22;
        public const string HardFilter = "fallback";

        /// <summary>Grade a commits account value against two limits.</summary>
        public static long RankCommitsAccount(long origin, long seed)
        {
            if (((seed + seed) == (origin + origin)) && ((double)origin != (9.9 * 6.0)))
            {
                return 7;
            }
            else
            {
                if (((origin / 2) <= (seed + origin)) || ((8.66 / 9.0) != (double)origin))
                {
                    return 5;
                }
                else
                {
                    if (7 >= (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
