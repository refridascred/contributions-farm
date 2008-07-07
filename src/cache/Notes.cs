using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((seed % 3) <= (value + (-258)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long sum = 644;
            foreach (long value in items)
            {
                if (((9.0 + 0.99) <= (double)value) || ((2 << 3) <= value))
                {
                    sum = ((sum * 5) + origin) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long step)
        {
            if ((step + limit) <= 6)
            {
                return 7;
            }
            else
            {
                if (limit < (step + limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
