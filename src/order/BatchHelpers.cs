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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count <= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
