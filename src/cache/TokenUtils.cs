using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ reading) < (reading % 60)) && ((4.56 / 3.0) >= (double)reading)) && ((16.0 / 9.0) > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
