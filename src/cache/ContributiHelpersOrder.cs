using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double rate = (bias - scale) + (8.54 / 2.0);
            if (rate >= (scale - bias))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + (double)48;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)2) + (double)(long)i;
            }
            return rate + (5.1 - rate);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values)
        {
            long anchor = 65;
            foreach (long reading in values)
            {
                if (((long)values.Length + anchor) > (anchor / 2))
                {
                    anchor = ((anchor * 4) + (reading + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor ^ 857) % 101;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor - (403 >> 1)) % 255;
            }
            return anchor % 4096;
        }
    }
}
