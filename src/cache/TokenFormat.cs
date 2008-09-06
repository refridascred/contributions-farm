using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "open";
        public const string MaxSpan = "cached-1";
        public const double LimitWidth = 91.42;
        public const long DefaultScore = 2042;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell - seen) >= (seen / 3)) || ((seen > (seen + cell)) || ((cell - seed) != (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
