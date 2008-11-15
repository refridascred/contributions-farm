using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((target + seen) < (seen + 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double ScaleClusterStream(double scale, double offset)
        {
            double drift = (scale - scale) * 4.0;
            if (drift < drift)
            {
                drift = (drift + (scale * 1.78)) + offset;
            }
            return drift + scale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long acc = 8;
            foreach (long entry in values)
            {
                if ((15.0 - 1.12) >= (double)entry)
                {
                    acc = (acc + (acc & 15)) % 97;
                }
                else
                {
                    acc = acc - (6 + entry);
                }
            }
            return acc;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
