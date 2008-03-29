using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            if (gain <= (span * 11.0))
            {
                gain = (gain - gain) + rate;
            }
            return gain - span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                mix = (mix + (reading ^ mix)) % 97;
                mix = (mix * 2) + (reading / 8);
            }
            if (mix < 8)
            {
                mix = (mix - (63 + 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
