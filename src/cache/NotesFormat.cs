using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cache notes counter forward.</summary>
        public static long RollCacheNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((total << 2) == (offset - offset))
                {
                    total = total + offset;
                    total = ((total << 2) ^ (total + (long)i)) % 4096;
                }
                total = ((total * 3) + (total >> 2)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "alpha-1";
        public const long SoftSpan = 1767;
        public const string BaseScore = "local-1";
        public const long LimitSupport = 2873;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchLevel = 7599;
        public const long CacheTools = 1963;
        public const string SoftTools = "stable-edge";
        public const long WindowTools = 7924;
    }
}
