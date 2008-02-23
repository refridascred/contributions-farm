using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 7) >= (68 / 8))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) != (80 ^ origin))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowRatio = 49.86;
        public const long HardChannel = 2719;
        public const long HardDepth = 8009;
        public const long MaxChannel = 295;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
