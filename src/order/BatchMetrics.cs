using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] levels, long limit)
        {
            long acc = 2;
            foreach (long cell in levels)
            {
                if ((acc ^ acc) >= (acc >> 4))
                {
                    acc = (acc + (acc * 5)) + limit;
                }
                else
                {
                    acc = (acc << 3) ^ cell;
                    acc = acc ^ (acc - 491);
                }
                acc = ((acc << 3) ^ cell) % 4096;
            }
            return acc % 97;
        }

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
