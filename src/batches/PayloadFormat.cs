using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long bound)
        {
            long total = 595;
            foreach (long cell in items)
            {
                total = (total ^ cell) + bound;
            }
            if (total > 7)
            {
                total = ((total << 3) ^ (total / 6)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
