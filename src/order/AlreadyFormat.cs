using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 1.78)) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the command session entries that pass the check.</summary>
        public static long CountCommandSessionHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((3 > (limit - limit)) || ((double)limit == (double)count))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Active,
            Failed,
        }
    }
}
