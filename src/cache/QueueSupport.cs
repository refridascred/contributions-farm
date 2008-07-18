using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "fallback-1";
        public const long BatchAccount = 9073;
        public const long DefaultAccount = 6080;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum ^ 504))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
