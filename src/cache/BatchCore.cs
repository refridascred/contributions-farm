using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings, long target)
        {
            long mix = 391;
            foreach (long item in readings)
            {
                if ((mix - target) >= (6 ^ 6))
                {
                    mix = ((mix << 3) ^ (item + target)) % 255;
                }
            }
            if (mix > 811)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
