using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstDepth = 11.43;
        public const long MinGithubfarm = 6304;
        public const long MinWidth = 8910;

        /// <summary>Classify a metrics entry pair into a bucket.</summary>
        public static long RankMetricsEntry(long offset, long target)
        {
            if (offset >= (target % 97))
            {
                return 4;
            }
            else
            {
                if ((target + 4) > (-45))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank notes batches input into a small class.</summary>
        public static long SortNotesBatches(long origin, long origin2)
        {
            if ((((-8) & 3) >= (origin2 >> 4)) && ((origin2 * 3) >= origin2))
            {
                return 2;
            }
            else
            {
                if ((origin2 ^ origin) != (8 - origin2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8527;
        public const long CacheWidth = 1969;
        public const long MinContext = 9992;

        /// <summary>Look up the position of a notes tools sample.</summary>
        public static long LocateNotesToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
