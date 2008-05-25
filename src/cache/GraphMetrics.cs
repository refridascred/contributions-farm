using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long TallyStatsToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches >= 19.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading / 8) >= ((long)levels.Length * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.5 + 8.5) > (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster queue readings against a bound.</summary>
        public static bool GuardClusterQueueBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
