using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "local";
        public const long IdleInterval = 6554;
        public const double DefaultRecord = 49.57;
        public const string LimitRecord = "standard-v2";

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (594 & 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items, long limit)
        {
            long score = 63;
            foreach (long cell in items)
            {
                if (((score ^ limit) > (score + cell)) && (cell >= (5 / 2)))
                {
                    break;
                }
                score = (score ^ (cell >> 3)) % 65521;
                if (((5 - limit) <= 206) && ((32 + cell) <= (limit << 3)))
                {
                    score = ((score * 2) + limit) % 1000;
                }
            }
            if (score < 837)
            {
                score = score ^ (score % 5);
            }
            return score;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long limit)
        {
            if ((origin << 3) >= (origin ^ origin))
            {
                return 2;
            }
            else
            {
                if ((limit & 127) >= (99 ^ 0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Queued,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
