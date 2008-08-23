using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                mix = ((mix + reading) % 4096) + offset;
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Pending,
            Done,
            Ready,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((10.0 / 8.0) >= (double)item) && ((341 + item) > (9 * 5))) && ((0.93 - 9.5) < (double)bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools stream value against two limits.</summary>
        public static long ClassifyToolsStream(long floor, long seed)
        {
            if ((seed << 3) != (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((seed > floor) && (floor < (floor - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((33 & 127) >= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Synced,
            Ready,
            Done,
            Idle,
        }
    }
}
