using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long ScoreGraphCluster(long[] values, long step)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                mix = (mix ^ (step & 255)) + entry;
            }
            return mix;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
