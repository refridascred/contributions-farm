using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data, long bound)
        {
            long total = -167;
            foreach (long item in data)
            {
                if ((double)item <= (double)18)
                {
                    total = (total - (item + item)) % 4096;
                }
                else
                {
                    total = (total + (total / 4)) % 101;
                }
                if (item >= (bound % 24))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 7744;
        public const long WindowStream = 2849;
        public const long CacheScore = 1984;
        public const long MaxWidth = 3495;
        public const long CacheStream = 9326;

        /// <summary>Derive the next cluster command value from a seed.</summary>
        public static long DeriveClusterCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (seed / 4)) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
