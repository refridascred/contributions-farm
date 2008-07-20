using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry ^ matches) > (matches % 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count stats channel pairs that satisfy a relation.</summary>
        public static long OverlapStatsChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 8594;
        public const string LimitCommits = "cached-v2";
        public const long BurstDepth = 8547;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up schema order samples.</summary>
        public static long OverlapSchemaOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
