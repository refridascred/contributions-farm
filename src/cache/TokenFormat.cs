using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Draft,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultWidth = "fallback-edge";
        public const double MaxLevel = 68.75;
        public const long WindowScore = 9797;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
