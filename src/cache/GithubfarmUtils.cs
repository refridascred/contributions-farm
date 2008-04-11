using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 888;
        public const long RetryOrder = 4380;
        public const long BurstOrder = 3446;
        public const long SoftSize = 4128;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches > (20.0 - 14.0))
                {
                    matches = ((matches + 1) + cell) - floor;
                }
            }
            return matches;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
