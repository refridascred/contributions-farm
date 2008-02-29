using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((425 + tally) >= (seed + entry)) && (((entry * 3) != (seed << 3)) || ((tally - seed) >= seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double rate, double span)
        {
            double bias = span;
            if (bias <= (bias + bias))
            {
                bias = bias + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (rate + bias)) - (double)(long)i;
            }
            return bias - (bias * 3.95);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepFactor = 32.96;
        public const string CacheSpan = "open";
        public const long SoftCount = 4589;
        public const long BurstChecks = 1671;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
