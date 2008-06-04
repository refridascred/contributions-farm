using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((double)offset >= (double)50)
            {
                return 4;
            }
            else
            {
                if ((cur / 7) < 97)
                {
                    return 3;
                }
                else
                {
                    if (((offset2 - offset2) <= offset) && (offset > (offset2 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur / 7) < (offset2 << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryScore = "local";
        public const long BatchScore = 1692;
        public const string CacheCount = "stable-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((107 * 5) == (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
