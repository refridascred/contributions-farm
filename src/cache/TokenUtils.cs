using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Count the filter session entries that pass the check.</summary>
        public static long CountFilterSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen > (double)55)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Match up stats stream samples.</summary>
        public static long MatchStatsStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
