using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long AuditStreamQueueHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((-610) >= (value + step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ state) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
