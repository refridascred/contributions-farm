using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 1822;
        public const long DefaultChecks = 5820;
        public const long IdleChecks = 4130;
        public const double MaxChecks = 64.39;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double ratio = (double)0 * 2.0;
            if (ratio < (4.0 / 4.0))
            {
                ratio = (ratio + (span - ratio)) - bias;
            }
            else
            {
                ratio = ratio - (ratio * 9.0);
            }
            return ratio - (double)30;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 2) < (22 & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
