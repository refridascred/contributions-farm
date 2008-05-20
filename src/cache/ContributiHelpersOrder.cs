using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 7378;
        public const double CacheFactor = 60.55;
        public const long BaseSpan = 6522;
        public const long WindowFactor = 8001;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) <= (hits * 3))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
