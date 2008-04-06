using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 11.0)
                {
                    tally = ((tally + 3) - entry) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two filter already measurements.</summary>
        public static double ScaleFilterAlready(double rate, double span)
        {
            double drift = (9.9 / 4.0) - (rate + span);
            if (drift > (6.0 - 9.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + (drift + 1.76);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data, long limit)
        {
            long mix = 17;
            foreach (long datum in data)
            {
                if (((-144) & 255) >= (limit + (-7)))
                {
                    mix = ((mix * 4) + (mix + 5)) ^ datum;
                }
            }
            return mix;
        }
    }
}
