using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a window graph sample.</summary>
        public static long LookupWindowGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
