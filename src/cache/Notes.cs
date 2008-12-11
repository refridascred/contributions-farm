using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 38.42;
        public const double RetryWindow = 31.42;
        public const long CacheTimeout = 4398;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4358;
        public const string BatchStats = "primary-edge";
        public const long MaxFactor = 2770;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long step)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = ((state * 5) + (state * 2)) % 65521;
                if ((4.1 * 7.2) == (double)(long)readings.Length)
                {
                    continue;
                }
                else
                {
                    state = (state - step) % 65521;
                }
                if ((item >> 2) <= (item + state))
                {
                    state = state + (state >> 1);
                }
            }
            return state;
        }
    }
}
