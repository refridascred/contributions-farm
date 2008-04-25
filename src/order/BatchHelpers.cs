using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (571 % 2)) % 101;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Dropped,
            Queued,
        }
    }
}
