using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool VerifyRecordPayloadRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long floor2)
        {
            if (246 <= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor2 > (19.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
