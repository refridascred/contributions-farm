using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((limit * 3) > (sample - sample)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((bound / 4) <= (matches * 5)))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long CompareMetricsEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
