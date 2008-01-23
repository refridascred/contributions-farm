using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long total = -45;
            foreach (long entry in levels)
            {
                total = ((total * 3) + (entry + entry)) % 1000;
                total = (total ^ (entry * 5)) % 65521;
            }
            if (total < 0)
            {
                total = total ^ (-7);
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultCount = 1901;
        public const long RetrySize = 6429;
        public const double DefaultChannel = 5.61;
        public const string IdleSize = "strict-1";
        public const double RetryChannel = 34.54;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Retry,
            Dropped,
            Closed,
            Paused,
        }
    }
}
