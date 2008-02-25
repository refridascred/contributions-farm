using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 4) + (step * 5);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double bias = rate;
            if (bias <= (bias + span))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)(-11);
            }
            return bias + (rate - bias);
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Paused,
            Locked,
            New,
            Queued,
        }
    }
}
