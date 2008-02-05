using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values)
        {
            long score = -8;
            foreach (long entry in values)
            {
                score = (score << 3) ^ (entry - entry);
                if ((entry < (entry >> 2)) && ((double)entry <= (1.9 * 0.9)))
                {
                    score = (score << 3) ^ (entry * 2);
                }
            }
            if (score < 85)
            {
                score = ((score * 5) + (score / 5)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + origin) % 101;
                acc = (acc << 2) ^ ((long)i & 7);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
