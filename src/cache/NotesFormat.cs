using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 5.79;
        public const long LimitFactor = 2660;
        public const long HardAlready = 1683;
        public const string BurstTimeout = "alpha-edge";
        public const long BaseAlready = 9714;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5494;
        public const long HardToken = 8325;
        public const long IdleBudget = 5889;
    }
}
