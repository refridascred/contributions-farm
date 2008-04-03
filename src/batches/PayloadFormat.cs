using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 5045;
        public const double HardPayload = 97.03;
        public const string LimitLevel = "local";

        /// <summary>Rank context cache input into a small class.</summary>
        public static long GradeContextCache(long origin, long offset)
        {
            if (((offset % 24) > (origin / 5)) && ((double)offset <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin + offset) <= (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (cell >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
