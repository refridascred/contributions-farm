using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate account already readings against a bound.</summary>
        public static bool CheckAccountAlreadyRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((floor - floor) != (entry / 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
