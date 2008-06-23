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

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

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
