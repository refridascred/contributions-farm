using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9746;
        public const string WindowLevel = "alpha";
        public const long BurstTimeout = 7071;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long TallyGithubfarmEditorMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) >= (seen - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
