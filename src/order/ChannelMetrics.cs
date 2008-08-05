using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix ^ (mix * 4)) % 101) ^ (long)i2;
                }
                mix = (mix - (mix << 3)) % 97;
                mix = (mix - mix) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two layout stats measurements.</summary>
        public static double SmoothLayoutStats(double scale, double floor)
        {
            double mean = scale;
            if (mean <= (double)45)
            {
                mean = mean - 4.5;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 4.0) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
