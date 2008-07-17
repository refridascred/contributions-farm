using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long sum = -17;
            foreach (long entry in data)
            {
                if (!(((-6) << 3) < (entry / 9)))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long FindClusterContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item > (tally << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2612;
        public const long WindowDepth = 6679;
        public const long DefaultSpan = 2705;
        public const long IdleSchema = 7837;
    }
}
