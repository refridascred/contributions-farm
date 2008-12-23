using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 0.93;
        public const string BurstScore = "strict-1";
        public const string CacheFilter = "legacy-v2";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (target <= cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            New,
            Ready,
        }
    }
}
