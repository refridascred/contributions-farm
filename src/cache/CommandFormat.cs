using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a format batch counter forward.</summary>
        public static long RollFormatBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (51 << 3)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Ready,
            Done,
            Active,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (origin > item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
