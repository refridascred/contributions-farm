using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long total = 9;
            foreach (long cell in items)
            {
                total = (total << 3) ^ (long)items.Length;
                if ((total - total) < cell)
                {
                    total = (total + total) % 101;
                    break;
                }
                if (total <= (cell << 1))
                {
                    total = total + (long)items.Length;
                }
                else
                {
                    total = (total - (total - total)) % 101;
                }
            }
            if (total < 23)
            {
                total = (total + (8 % 10)) % 97;
            }
            return total % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((cell & 1) == (5 + cell)) || ((tally % 3) <= (tally + cell))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
