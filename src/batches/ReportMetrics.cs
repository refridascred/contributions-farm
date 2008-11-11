using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a farm schema reading by value.</summary>
        public static long LocateFarmSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool CheckMetricGraphRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
