using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double load = (double)(5 - 67);
            if (load <= (double)675)
            {
                load = (load + weight) - floor;
            }
            return load + 19.0;
        }
    }
}
