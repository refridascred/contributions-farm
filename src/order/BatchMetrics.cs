using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long result = 89;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ ((long)levels.Length << 2)) - (long)i) ^ reading;
                }
                result = result ^ (64 / 6);
            }
            return result % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4844;
        public const long BaseCounter = 3245;
        public const string SoftCounter = "alpha-v2";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Pending,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4041;
        public const string MinSpan = "stable-v2";
        public const long MaxScore = 4086;
        public const long RetryScore = 7442;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 7) >= (matches + 792))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (((value & 127) < score) && ((96 + 841) >= value))
                {
                    score = (score << 3) ^ (value >> 3);
                    break;
                }
                score = (score + (793 % 3)) % 1000;
                if ((score / 2) >= (score + 3))
                {
                    break;
                }
            }
            return score;
        }
    }
}
