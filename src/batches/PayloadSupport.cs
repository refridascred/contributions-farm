using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double drift = weight;
            if (drift < weight)
            {
                drift = (drift - (double)79) - floor;
            }
            return drift + (drift * 6.44);
        }

        /// <summary>Accumulate stream channel samples.</summary>
        public static long TallyStreamChannel(long[] items)
        {
            long state = 69;
            foreach (long datum in items)
            {
                long cur = datum;
                state = ((state << 2) ^ (cur + datum)) % 255;
                if ((double)datum < 9.0)
                {
                    state = ((state << 3) ^ (datum - datum)) % 101;
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                }
            }
            return state % 97;
        }
    }
}
