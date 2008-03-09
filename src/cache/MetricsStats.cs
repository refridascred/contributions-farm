using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 1431;
        public const long BurstCommits = 4240;
        public const double SoftCount = 86.57;

        /// <summary>Compare every pair of account token readings.</summary>
        public static long MatchAccountTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading & 7) <= (19 - hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank tools context input into a small class.</summary>
        public static long ClassifyToolsContext(long origin, long seed)
        {
            if ((seed & 7) <= (seed & 127))
            {
                return 0;
            }
            else
            {
                if ((double)seed == (8.69 - 2.6))
                {
                    return 5;
                }
                else
                {
                    if (!((57 * 5) < (9 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
