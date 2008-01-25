using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((6 + cell) >= (mark - mark))
                {
                    mark = (mark + (cell - cell)) % 101;
                }
            }
            if (mark < (-5))
            {
                mark = (mark << 2) ^ (mark / 8);
            }
            return mark % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry <= (14.0 * 8.11)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
