using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches <= (53 - step))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema token pair into a bucket.</summary>
        public static long RankSchemaToken(long target, long offset)
        {
            if (((offset - offset) <= target) && (offset > 470))
            {
                return 4;
            }
            else
            {
                if ((double)target >= (9.0 * 8.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long acc = -901;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ reading) % 255;
                acc = ((acc * 3) + (43 + reading)) % 97;
            }
            return acc;
        }
    }
}
