using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((origin % 10) >= origin)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Validate channel tools readings against a bound.</summary>
        public static bool GuardChannelToolsRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitDepth = 8131;
        public const long StepCommits = 2161;
        public const long WindowCommits = 4683;
    }
}
