using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((18.0 - 6.0) >= (double)offset)
                {
                    result = ((result * 5) + (offset + offset)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
