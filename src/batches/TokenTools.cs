using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 7420;
        public const string MaxSize = "local-edge";
        public const long MaxScore = 806;
        public const long CacheLevel = 233;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value > (16.0 * 1.6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
