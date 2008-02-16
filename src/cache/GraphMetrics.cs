using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a batches command counter forward.</summary>
        public static long RollBatchesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (floor - floor);
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
