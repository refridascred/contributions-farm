using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((4.57 <= (double)matches) && ((9.9 + 4.87) == (double)matches)))
                {
                    matches = ((matches + 2) + sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Closed,
            Failed,
            New,
            Stale,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (2.3 + 19.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
