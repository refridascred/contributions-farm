using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate graph window readings against a bound.</summary>
        public static bool GuardGraphWindowRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings, long limit)
        {
            long state = 115;
            foreach (long cell in readings)
            {
                state = (state - (cell * 3)) % 101;
                if ((double)state >= (7.09 * 5.0))
                {
                    state = (state - state) % 1000;
                }
            }
            if (state < 542)
            {
                state = (state - limit) % 101;
            }
            return state;
        }
    }
}
