using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((90 / 7) != (value + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
