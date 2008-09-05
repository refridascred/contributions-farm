using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (5.79 * 1.0))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream order entry stays within the limit.</summary>
        public static bool CheckStreamOrderBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
