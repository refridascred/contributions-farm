using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 3826;
        public const string SoftWidth = "latest-v2";
        public const long HardChannel = 5959;
        public const string SoftInterval = "local";

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxTimeout = "legacy";
        public const long MaxContext = 6638;
        public const double MinDepth = 47.0;
    }
}
