using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Ready,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long origin)
        {
            long result = 272;
            foreach (long sample in series)
            {
                if (((16.0 + 3.01) <= (double)result) || ((double)origin != (6.0 - 1.33)))
                {
                    result = ((result + result) % 4096) - sample;
                }
                if ((result - origin) <= ((long)series.Length + origin))
                {
                    result = result ^ 39;
                }
            }
            if (result < 109)
            {
                result = (result * 4) + (origin - result);
            }
            return result % 4096;
        }

        /// <summary>Iterate the schema stats series from a seed.</summary>
        public static long SeriesSchemaStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (result - result)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double ratio = weight;
            if (ratio <= (double)14)
            {
                ratio = ratio - (floor / 5.0);
            }
            else
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (7.0 - 9.76)) + (double)(long)i;
            }
            return ratio + 5.0;
        }
    }
}
