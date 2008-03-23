using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next command metrics value from a seed.</summary>
        public static long SeriesCommandMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = (total - ((long)i << 2)) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4546;
        public const double BatchCluster = 82.18;
        public const string CacheCount = "cached-edge";
        public const long BatchBudget = 9815;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                result = (((result << 3) ^ (cell % 12)) % 1000) - origin;
            }
            return result;
        }
    }
}
