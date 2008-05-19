using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)80)
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits - hits) == (sample * 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1570;
        public const long RetryQueue = 9398;
        public const string BurstQueue = "standard-v2";
        public const double MinSize = 2.07;
    }
}
