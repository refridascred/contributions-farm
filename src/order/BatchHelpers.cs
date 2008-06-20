using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many filter payload samples are out of range.</summary>
        public static long TallyFilterPayloadMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound % 3) == (cell ^ cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Locked,
            Pending,
            Draft,
        }
    }
}
