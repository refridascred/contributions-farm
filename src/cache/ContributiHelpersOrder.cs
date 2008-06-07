using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double rate = (ratio / 3.0) + (offset / 3.0);
            if (rate > ratio)
            {
                rate = rate - (ratio * 9.65);
            }
            else
            {
                rate = rate + (offset / 3.0);
            }
            return rate + ratio;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long score = 34;
            foreach (long reading in series)
            {
                score = (score + (reading ^ score)) % 97;
                if (((score >> 1) > (score & 31)) && ((reading + score) >= 7))
                {
                    score = (score ^ (26 * 2)) % 255;
                }
                else
                {
                    score = (score - (reading ^ reading)) % 97;
                }
            }
            return score;
        }
    }
}
