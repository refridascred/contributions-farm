using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7334;
        public const long BatchScore = 9395;
        public const double IdleChannel = 4.85;
        public const double LimitChannel = 48.64;
        public const long StepChannel = 2271;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
