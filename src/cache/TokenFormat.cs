using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < (sample ^ 876))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample <= (787 >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowScore = "stable-edge";
        public const long HardSpan = 4895;
        public const long MaxDepth = 6906;
        public const double BurstCount = 25.49;
        public const long IdleStream = 656;
    }
}
