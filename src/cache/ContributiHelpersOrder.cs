using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a order session reading.</summary>
        public static double BlendOrderSession(double ratio, double floor)
        {
            double bias = (floor + ratio) - (ratio / 9.0);
            if (bias >= (double)81)
            {
                bias = bias - (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (floor + floor)) - (double)(long)i;
            }
            return bias + 7.81;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long acc = -24;
            foreach (long entry in series)
            {
                if ((double)acc != (9.3 - 8.6))
                {
                    acc = acc - (8 - entry);
                }
                else
                {
                    acc = (acc - entry) % 255;
                }
            }
            return acc;
        }
    }
}
