using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks stream readings.</summary>
        public static long MatchChecksStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftBudget = "local-1";
        public const long DefaultRatio = 2487;
        public const long StepCommand = 1799;
        public const long CacheCommand = 9679;

        /// <summary>Count the batches layout entries that pass the check.</summary>
        public static long MeasureBatchesLayoutGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(count <= cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Find the first buffer filter entry that matches the target.</summary>
        public static long SeekBufferFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long GradeCacheChannel(long origin, long offset)
        {
            long lane = origin - offset;
            if ((lane >= (685 + 75)) && ((origin / 9) == (offset << 2)))
            {
                return 4;
            }
            else
            {
                if ((double)origin != (1.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    if (!((origin % 100) < (origin % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
