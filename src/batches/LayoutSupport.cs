using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next layout buffer value.</summary>
        public static double ScaleLayoutBuffer(double weight, double bias)
        {
            double gain = (double)(184 << 2);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (double)(long)i) - weight) - bias;
            }
            return gain - (double)908;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Closed,
            Synced,
            Pending,
        }
    }
}
