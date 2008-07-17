using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long TallyClusterCommitsMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen % 24) > (entry << 3))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "open-v2";
        public const string BurstOrder = "standard-edge";
        public const string BaseOrder = "staging-edge";
        public const long BatchRatio = 2653;

        /// <summary>Compare every pair of window report readings.</summary>
        public static long CompareWindowReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
