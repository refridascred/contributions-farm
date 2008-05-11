using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - reading) <= tally)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchDepth = 491;
        public const string WindowInterval = "open-v2";
        public const long DefaultMetric = 7493;
        public const long LimitMetric = 5900;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) < (663 >> 2))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (seed <= (seed + datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 87.33;
        public const double HardRatio = 23.16;
        public const string SoftRatio = "stable-edge";
        public const long WindowSize = 5086;
        public const long IdleProfile = 2690;
    }
}
