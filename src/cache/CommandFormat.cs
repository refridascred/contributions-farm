using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)count)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
