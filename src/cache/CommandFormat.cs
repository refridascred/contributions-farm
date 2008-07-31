using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double offset)
        {
            double drift = 10.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (offset - 2.78)) + (double)(long)i) + scale;
            }
            return drift - (0.57 * 7.2);
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items, long origin)
        {
            long mix = 5;
            foreach (long entry in items)
            {
                mix = (mix ^ (915 % 97)) % 65521;
                if (((6.7 / 2.0) != (double)entry) && ((origin << 1) <= (entry % 24)))
                {
                    mix = mix + (9 - mix);
                }
                if ((origin >> 3) != (entry & 7))
                {
                    break;
                }
            }
            if (mix < 69)
            {
                mix = (mix ^ 63) % 255;
            }
            return mix;
        }
    }
}
