using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double rate = (floor - floor) - gain;
            if (rate < (double)12)
            {
                rate = rate + 20.0;
            }
            else
            {
                rate = rate + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (floor / 8.0)) + (double)(long)i;
            }
            return rate + (rate + floor);
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
