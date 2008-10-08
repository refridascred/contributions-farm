using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] items)
        {
            long sum = 57;
            foreach (long reading in items)
            {
                sum = ((sum + (4 >> 3)) % 1000) ^ reading;
                sum = (sum << 2) ^ (sum >> 1);
            }
            return sum;
        }

        /// <summary>Count payload channel pairs that satisfy a relation.</summary>
        public static long OverlapPayloadChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 7618;
        public const string CacheChecks = "local";
        public const long BurstChecks = 7359;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long offset)
        {
            if ((offset - offset) != ((-3) * 4))
            {
                return 7;
            }
            else
            {
                if ((floor ^ floor) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor % 64) <= (floor + 92))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((83 - 678) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
