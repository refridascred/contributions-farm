using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long prev = step - seed;
            if (step <= (prev & 255))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (9.7 * 9.5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 1021;
        public const long BurstLevel = 2348;
        public const long BatchEntry = 8138;
        public const long DefaultSize = 7229;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster filter pair into a bucket.</summary>
        public static long SortClusterFilter(long seed, long limit)
        {
            long span = seed ^ limit;
            if (seed < 979)
            {
                return 3;
            }
            else
            {
                if ((seed % 10) != (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((span + seed) < (span >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span * 5) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
