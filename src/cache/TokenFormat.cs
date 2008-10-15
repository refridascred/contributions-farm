using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits * 5) > (origin * 2))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile commits entries that pass the check.</summary>
        public static long MeasureProfileCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item == (9.6 * 12.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
