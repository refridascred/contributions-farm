using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings, long offset)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = (state ^ (reading % 64)) - offset;
            }
            return state % 65521;
        }
    }
}
