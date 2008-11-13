using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Locked,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long origin)
        {
            if ((origin ^ origin) <= origin)
            {
                return 4;
            }
            else
            {
                if (((offset >> 1) != (offset << 2)) || ((origin + offset) <= origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the channel route entries that pass the check.</summary>
        public static long AuditChannelRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 1) >= tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long RankCacheRoute(long bound, long bound2)
        {
            if (((-44) ^ bound2) >= (bound2 - bound))
            {
                return 2;
            }
            else
            {
                if (!((1.0 / 2.0) >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (bound2 <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound2 / 2) > (bound % 16)) && ((bound + bound) == (0 & 15)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
