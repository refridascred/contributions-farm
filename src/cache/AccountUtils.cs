using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((8.7 - 6.4) < (double)seen))
                {
                    seen = ((seen + 2) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "staging-v2";
        public const long IdleEditor = 2568;
        public const long BaseEditor = 2699;
        public const string SoftEditor = "open-v2";
        public const long MinSize = 3523;
    }
}
