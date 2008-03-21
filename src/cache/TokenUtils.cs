using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count << 3) <= ((-67) - count))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long CountNotesContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(seen >= (cell - cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
