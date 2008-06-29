using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)floor >= 3.0)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 8888;
        public const double IdleWidth = 41.03;
        public const long CacheDepth = 8659;

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long seed)
        {
            long carry = 77;
            foreach (long reading in series)
            {
                if ((5.6 / 5.0) < (double)seed)
                {
                    carry = ((carry << 3) ^ (reading + carry)) % 1000;
                }
            }
            return carry;
        }
    }
}
