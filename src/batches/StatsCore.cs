using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)offset == (4.7 - 9.6))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue route pair into a bucket.</summary>
        public static long SortQueueRoute(long seed, long limit)
        {
            if (((limit - 31) == (seed - seed)) || ((limit << 2) > (3 + 14)))
            {
                return 5;
            }
            else
            {
                if ((seed % 5) <= (limit + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((seed & 7) > seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheCount = 44.42;
        public const double IdleFactor = 65.2;
        public const long MaxTimeout = 7572;
        public const long MinDepth = 8413;

        /// <summary>Match up commits tools samples.</summary>
        public static long OverlapCommitsToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 1140;
        public const long BaseFactor = 998;
        public const double BurstChannel = 85.23;
        public const double RetryChannel = 48.06;
        public const double CacheLevel = 70.64;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
