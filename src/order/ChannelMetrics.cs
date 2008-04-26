using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cluster stream readings against a rule.</summary>
        public static long MeasureClusterStreamMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((1 - hits) > (757 << 2))
                {
                    hits = ((hits + 3) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 651;
        public const string MinFactor = "open-1";
        public const double SoftSpan = 53.34;

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 96;
            foreach (long value in data)
            {
                result = (result << 2) ^ (result & 127);
                result = result + result;
                result = (result ^ (result - value)) % 4096;
            }
            return result;
        }
    }
}
