using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry / 3) > (entry - (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
