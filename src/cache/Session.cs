using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheDepth = 1368;
        public const string BaseBudget = "fallback-1";
        public const long BurstCount = 7390;
        public const long MaxRoute = 2212;

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double span)
        {
            double weight = (gain + span) + 0.7;
            if (weight < weight)
            {
                weight = weight - weight;
            }
            return weight - (span - gain);
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((reading - 27) < (reading / 4)) || ((seen & 15) != (seen * 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
