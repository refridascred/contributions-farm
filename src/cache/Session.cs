using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "fallback-1";
        public const long LimitCount = 198;
        public const string HardWidth = "primary";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (7.7 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
