using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double scale = offset;
            if (scale < (rate - scale))
            {
                scale = scale + (double)973;
            }
            return scale - (scale + offset);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
