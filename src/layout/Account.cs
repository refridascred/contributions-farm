using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Failed,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
