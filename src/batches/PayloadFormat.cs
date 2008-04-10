using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
