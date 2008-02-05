using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinLevel = 66.9;
        public const string DefaultCache = "cached-1";
        public const string BatchCache = "strict";

        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool CheckSchemaNotesRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
