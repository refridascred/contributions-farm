using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
