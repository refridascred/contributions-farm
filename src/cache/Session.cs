using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (floor > (seen * 2))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultScore = "standard-v2";
        public const long BaseCache = 4321;
        public const string CacheCount = "fallback-edge";

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
