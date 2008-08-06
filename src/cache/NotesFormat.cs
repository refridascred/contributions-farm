using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double bias = rate + offset;
            if (bias >= bias)
            {
                bias = bias - (offset - bias);
            }
            else
            {
                bias = bias - (rate - offset);
            }
            return bias - (offset / 3.0);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                mix = ((mix * 2) + value) % 65521;
                mix = mix + value;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
