using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many cluster support samples are out of range.</summary>
        public static long CountClusterSupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item > (item - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1009;
        public const long IdleScore = 4466;
        public const string IdleBatches = "latest-edge";
        public const double RetryRatio = 94.32;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
