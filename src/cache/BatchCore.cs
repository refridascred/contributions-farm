using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long limit)
        {
            long anchor = 67;
            foreach (long item in items)
            {
                anchor = (((anchor * 4) + ((long)items.Length << 2)) ^ item) - limit;
            }
            if (anchor < 631)
            {
                anchor = (anchor + (anchor & 15)) % 255;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics batches value from a seed.</summary>
        public static long RollMetricsBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ 29) % 4096;
                if ((result + seed) > seed)
                {
                    result = ((result << 3) ^ ((long)i % 24)) % 97;
                    result = result - (result & 63);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
