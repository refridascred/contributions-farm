using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultWidth = 9323;
        public const long SoftBatches = 3436;
        public const long WindowLevel = 1328;
        public const string DefaultDepth = "legacy-edge";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up metrics command samples.</summary>
        public static long PairMetricsCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
