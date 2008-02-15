using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long LookupChannelToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum % 60) < (hits & 7))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
