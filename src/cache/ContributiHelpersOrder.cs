using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 5) < (count >> 4))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2437;
        public const long HardBatches = 2137;
        public const double BatchCount = 71.45;
        public const long BatchBatches = 653;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long offset)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                if (((long)items.Length % 2) >= (cell + 69))
                {
                    mix = (mix << 2) ^ (86 & 63);
                }
            }
            if (mix < 733)
            {
                mix = mix - (offset ^ mix);
            }
            return mix % 65521;
        }
    }
}
