using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheRatio = 77.57;
        public const string BurstRatio = "primary-edge";
        public const long StepBudget = 2374;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
