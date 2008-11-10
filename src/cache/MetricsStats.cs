using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((17.0 + 11.0) >= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i ^ origin)) % 97;
                }
                carry = carry ^ (origin + (long)i);
                if (((long)i ^ 5) <= carry)
                {
                    carry = (carry << 3) ^ (origin - origin);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((808 - 331) > (0 - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long limit)
        {
            long sum = 5;
            foreach (long sample in series)
            {
                sum = ((sum * 2) + ((long)series.Length ^ limit)) ^ sample;
                sum = (sum + (sum >> 5)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseScore = 8699;
        public const long SoftAccount = 106;
        public const long IdleDepth = 7387;
        public const long IdleAccount = 9531;
        public const string BurstCount = "open-edge";
    }
}
