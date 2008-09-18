using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length > (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((77 % 16) > matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long origin, long bound)
        {
            if ((0.8 * 5.0) != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (6.47 / 3.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
