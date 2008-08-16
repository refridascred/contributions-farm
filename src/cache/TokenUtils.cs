using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value ^ count) != (count * 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
