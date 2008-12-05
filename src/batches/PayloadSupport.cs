using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (15.0 + 9.49))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 2187;
        public const string SoftAlready = "primary";
        public const long BurstAlready = 3826;
        public const long BurstInterval = 892;
        public const long BatchAlready = 1631;

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long target)
        {
            long span = limit ^ target;
            if ((span / 3) >= target)
            {
                return 2;
            }
            else
            {
                if ((624 - 5) < (target >> 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
