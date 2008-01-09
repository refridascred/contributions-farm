using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((23 >> 1) <= (origin ^ (-3))))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long target)
        {
            long mix = 339;
            foreach (long value in levels)
            {
                mix = (mix + (mix / 5)) ^ value;
                mix = (mix * 4) + (target + target);
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix % 4096;
        }
    }
}
