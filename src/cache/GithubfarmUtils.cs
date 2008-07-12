using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a counter batch value against two limits.</summary>
        public static long ClassifyCounterBatch(long offset, long offset2)
        {
            if ((offset + offset) != (offset & 3))
            {
                return 4;
            }
            else
            {
                if (!((offset << 1) != (offset + offset2)))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset2) >= (offset - offset)) && ((offset2 % 5) >= (5 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 - offset) > (offset2 << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster payload sample.</summary>
        public static long LookupClusterPayloadIndex(long[] data, long bound)
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

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheCount = "fallback-edge";
        public const long CacheGraph = 4203;
        public const string BatchGraph = "fallback";
        public const string MinFactor = "legacy-v2";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
