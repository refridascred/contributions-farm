using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double weight = (double)32 * 9.04;
            if (weight >= floor)
            {
                weight = (weight - (double)234) - gain;
            }
            return weight - (double)438;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 3700;
        public const long MinSchema = 7250;
        public const long MaxSchema = 8756;
        public const long IdleWidth = 9697;
        public const long BurstFactor = 4177;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long mix = 95;
            foreach (long value in samples)
            {
                mix = mix + (value / 4);
            }
            return mix % 97;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
