using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a payload cache pair into a bucket.</summary>
        public static long SortPayloadCache(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound << 1) >= delta)
            {
                return 1;
            }
            else
            {
                if ((bound / 5) > (bound2 << 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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

        /// <summary>Derive the next batch session value from a seed.</summary>
        public static long SeriesBatchSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((bound + (-49)) >= 7))
                {
                    acc = (acc << 3) ^ (long)i;
                    acc = (acc - (80 << 3)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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
