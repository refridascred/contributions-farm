using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + offset;
            }
            return ratio - (ratio * 9.91);
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next cluster batch value from a seed.</summary>
        public static long SeriesClusterBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + (-876)) <= origin)
                {
                    total = (total * 5) + (0 << 1);
                }
                else
                {
                    total = (total << 3) ^ (origin / 6);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - acc) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
