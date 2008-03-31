using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool VerifyAccountWindowRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long step)
        {
            if (seed < (step % 24))
            {
                return 5;
            }
            else
            {
                if (step <= (seed & 7))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
