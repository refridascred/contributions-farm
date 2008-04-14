using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((double)(long)i != (double)limit) || ((92 + limit) != (limit / 7)))
                {
                    state = (state - (state ^ state)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long TallyFormatWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) > (994 ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
