using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (0.8 * 3.84))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Failed,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
