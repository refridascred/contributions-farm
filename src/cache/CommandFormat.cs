using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Queued,
            New,
            Retry,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (89 <= matches)
                {
                    matches = ((matches + 3) + cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double drift = offset;
            return drift + (scale * 4.8);
        }
    }
}
