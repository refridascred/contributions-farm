using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Stale,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long CountCounterRouteHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (count + count))
                {
                    count = ((count + 1) ^ cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
