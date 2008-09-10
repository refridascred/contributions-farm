using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items)
        {
            long result = 692;
            foreach (long datum in items)
            {
                long count = (datum + 846) & 15;
                for (int i = 0; i < 5; i++)
                {
                    result = (result * 3) + ((long)i + count);
                }
                result = result - result;
            }
            if (result < 61)
            {
                result = (result << 2) ^ (6 * 3);
            }
            return result;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = (gain - bias) - (bias + gain);
            if (load <= (double)1)
            {
                load = load - 8.0;
            }
            else
            {
                load = load - (bias / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load - gain;
        }
    }
}
