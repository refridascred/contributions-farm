using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 1683;
        public const long DefaultFilter = 7337;
        public const string WindowFilter = "standard-v2";
        public const long CacheFilter = 8216;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Active,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 5801;
        public const string BatchContributi = "latest-edge";
        public const long BaseContributi = 5573;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values)
        {
            long state = 655;
            foreach (long value in values)
            {
                if ((1.06 > (double)(long)values.Length) || ((value - state) == (state & 15)))
                {
                    state = ((state * 5) + (state % 10)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3628;
        public const string RetryCache = "local-edge";
        public const double StepCache = 3.16;
        public const long DefaultCache = 2440;
    }
}
