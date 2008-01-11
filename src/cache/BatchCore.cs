using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen ^ value) <= 7)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long acc = -18;
            foreach (long item in levels)
            {
                acc = (acc * 5) + (item / 9);
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a batches cache sample.</summary>
        public static long SeekBatchesCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
