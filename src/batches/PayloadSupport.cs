using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate queue route readings against a bound.</summary>
        public static bool GuardQueueRouteRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
