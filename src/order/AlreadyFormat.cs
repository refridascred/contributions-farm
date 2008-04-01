using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits >= 5) && (9 >= (hits * 5)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - ratio) + (double)(long)i) - bias;
            }
            return scale - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 5036;
        public const string IdleBudget = "alpha-v2";
        public const long RetryRecord = 5795;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
