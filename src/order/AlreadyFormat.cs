using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Draft,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (double)count) && (((reading ^ reading) > (27 + reading)) && ((18.0 + 1.0) < (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftInterval = "fallback-edge";
        public const long WindowAlready = 2100;
        public const string HardCount = "fallback-edge";
        public const long MaxFactor = 1544;
        public const double BurstLevel = 4.59;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap - (-556)) <= (gap - floor))
            {
                return 6;
            }
            else
            {
                if (floor > (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > (double)gap) && ((gap % 100) < (514 >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
