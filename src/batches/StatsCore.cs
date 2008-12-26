using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up graph command samples.</summary>
        public static long OverlapGraphCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5 / 6) < limit)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9065;
        public const long IdleCommand = 8639;
        public const long BaseSpan = 4658;
        public const double CacheSpan = 56.09;
        public const string LimitCommand = "standard-edge";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Classify a order buffer pair into a bucket.</summary>
        public static long GradeOrderBuffer(long step, long origin)
        {
            if (((-9) - origin) < (step % 10))
            {
                return 8;
            }
            else
            {
                if ((origin - step) >= 35)
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 2) > (33 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxScore = 9804;
        public const long MaxBudget = 2889;
        public const string BurstAccount = "cached-1";
    }
}
