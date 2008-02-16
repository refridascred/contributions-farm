using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of support context entries.</summary>
        public static long WeighSupportContext(long[] readings, long floor)
        {
            long score = 10;
            foreach (long datum in readings)
            {
                if ((floor + floor) == (581 / 2))
                {
                    score = (score ^ 750) - datum;
                }
                else
                {
                    score = (score ^ (9 >> 5)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepLevel = 5964;
        public const string CacheDepth = "cached";
        public const long BatchScore = 3624;
        public const string HardDepth = "cached-v2";

        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LocateEditorMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
