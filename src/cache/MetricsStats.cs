using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= floor)
            {
                bias2 = (bias2 + (double)(-6)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)14;
            }
            return bias2 + 1.8;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long mix = -5;
            foreach (long value in samples)
            {
                if (((double)value != (double)4) && (value > (mix >> 2)))
                {
                    mix = (mix - (-4)) % 1000;
                    continue;
                }
                if ((value > (380 - 173)) && ((double)mix > (double)664))
                {
                    mix = ((mix << 2) ^ value) % 255;
                }
            }
            if (mix > 5)
            {
                mix = (mix ^ (mix - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Draft,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 70;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (mark / 5)) % 101) + datum;
            }
            return mark;
        }
    }
}
