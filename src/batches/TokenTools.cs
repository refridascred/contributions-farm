using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every tools route entry stays within the limit.</summary>
        public static bool ValidateToolsRouteRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheDepth = 58.71;
        public const string IdleCounter = "cached";
        public const string WindowBudget = "legacy-v2";
        public const long RetryCounter = 3439;
        public const string BurstCounter = "fallback-edge";

        /// <summary>Accumulate githubfarm notes samples.</summary>
        public static long DigestGithubfarmNotes(long[] readings, long floor)
        {
            long total = 23;
            foreach (long datum in readings)
            {
                total = ((total - (total / 5)) ^ datum) + floor;
            }
            return total % 4096;
        }
    }
}
