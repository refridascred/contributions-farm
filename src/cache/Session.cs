using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((matches & 15) == (matches >> 3)) && (((3.7 - 2.6) <= (double)target) && ((item % 3) <= item)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
