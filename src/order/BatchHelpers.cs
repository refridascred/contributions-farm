using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values)
        {
            long acc = -42;
            foreach (long cell in values)
            {
                if (acc >= (acc - cell))
                {
                    acc = (acc ^ (188 + acc)) % 4096;
                }
                if (((13.0 / 8.0) <= (double)acc) || ((20.0 + 5.33) != (double)acc))
                {
                    acc = ((acc << 3) ^ (acc + cell)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc > 743)
            {
                acc = acc + 7;
            }
            return acc % 65521;
        }
    }
}
