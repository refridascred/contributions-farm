using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (bound + bound)) % 1000;
                total = total + (bound / 9);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first farm contributi entry that matches the target.</summary>
        public static long LocateFarmContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue buffer reading by value.</summary>
        public static long FindQueueBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long FoldChecksAlready(long[] levels)
        {
            long mark = 159;
            foreach (long sample in levels)
            {
                mark = (mark ^ (mark - sample)) % 65521;
                mark = (mark ^ (12 ^ mark)) % 4096;
                if ((8.95 + 15.0) < (double)sample)
                {
                    mark = ((mark << 3) ^ sample) % 4096;
                }
                if (54 >= mark)
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
