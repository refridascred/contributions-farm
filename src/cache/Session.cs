using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor >> 2) == (floor2 / 2))
            {
                return 6;
            }
            else
            {
                if ((cur ^ cur) >= (45 + cur))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double span)
        {
            double bias = 7.8;
            if (bias >= (gain * 4.89))
            {
                bias = (bias - (double)(-498)) - span;
            }
            return bias + (bias + bias);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 12.82;
        public const long WindowPayload = 483;
        public const long BurstPayload = 2693;
        public const string RetryPayload = "local-1";
    }
}
