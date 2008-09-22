using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((6.7 + 7.0) > (double)seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "fallback-1";
        public const long CacheCounter = 7;
        public const long HardRatio = 7872;
        public const double BatchDepth = 57.97;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7034;
        public const long SoftSupport = 1922;
        public const double BurstSupport = 44.27;
        public const double BurstCount = 35.74;
    }
}
