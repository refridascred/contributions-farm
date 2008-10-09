using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ matches) > (62 << 1))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double bias3 = bias / 8.0;
            if (bias3 > (double)708)
            {
                bias3 = (bias3 + (double)790) + bias2;
            }
            else
            {
                bias3 = bias3 + (bias / 5.0);
            }
            return bias3 + (double)(-4);
        }
    }
}
