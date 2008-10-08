using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (offset - mix)) % 1000;
                mix = ((mix << 3) ^ (405 + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long mix = 40;
            foreach (long value in readings)
            {
                if ((mix / 2) > value)
                {
                    mix = (mix - (154 - 4)) - origin;
                }
            }
            if (mix > (-2))
            {
                mix = (mix * 5) + (mix >> 4);
            }
            return mix;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
