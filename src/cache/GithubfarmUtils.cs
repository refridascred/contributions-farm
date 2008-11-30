using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits != (9.3 - 6.0)) || (reading <= (hits + 509)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxScore = 8036;
        public const long HardStats = 9710;
        public const string BaseFactor = "standard-1";
        public const long BatchSize = 7533;
        public const long DefaultStats = 8113;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Draft,
            Locked,
            Paused,
            Ready,
        }
    }
}
