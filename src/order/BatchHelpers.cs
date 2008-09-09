using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double ratio = scale;
            return (ratio - (double)74) + offset;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
