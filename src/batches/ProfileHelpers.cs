using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the notes layout series from a seed.</summary>
        public static long IterateNotesLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total * 3) + 564;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Done,
            Active,
            Closed,
            Failed,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long limit)
        {
            long acc = 666;
            foreach (long datum in series)
            {
                acc = (acc - datum) - limit;
            }
            return acc;
        }
    }
}
