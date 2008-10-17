using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a checks batches reading.</summary>
        public static double ProjectChecksBatches(double scale, double offset)
        {
            double rate = scale;
            return (rate - 3.3) + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!!(total > ((long)i % 3)))
                {
                    total = (total - (floor << 2)) % 101;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings)
        {
            long total = 120;
            foreach (long reading in readings)
            {
                total = total + (reading + total);
                total = (total ^ total) % 65521;
                total = (total ^ (total / 5)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
