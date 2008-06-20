using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double bias = (double)(5 + 2);
            if (bias < offset)
            {
                bias = (bias + (bias / 2.0)) - ratio;
            }
            else
            {
                bias = bias - (7.0 * 12.0);
            }
            return bias - (8.54 - bias);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items, long offset)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if (sample >= mix)
                {
                    mix = ((mix << 3) ^ (offset + sample)) % 4096;
                }
                else
                {
                    mix = (mix - (sample / 8)) % 97;
                }
            }
            if (mix > 284)
            {
                mix = (mix + (mix + offset)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
