using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
