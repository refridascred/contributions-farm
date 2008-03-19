using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the schema cache entries that pass the check.</summary>
        public static long MeasureSchemaCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample > (seen ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
