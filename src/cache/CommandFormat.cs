using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Draft,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a context token sample.</summary>
        public static long FindContextTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values)
        {
            long acc = 251;
            foreach (long entry in values)
            {
                if ((double)3 != (double)entry)
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                else
                {
                    acc = (acc ^ (acc ^ acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
