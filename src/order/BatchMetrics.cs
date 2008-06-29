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

        /// <summary>Roll a support entry counter forward.</summary>
        public static long DeriveSupportEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                bool stale = (limit & 31) > (long)i;
                if (stale && ((limit >> 2) <= mix))
                {
                    stale = (78 + (long)i) > limit;
                    mix = (mix - (63 & 31)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
