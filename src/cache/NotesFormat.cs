using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Stale,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((lane - lane) >= lane)
            {
                return 4;
            }
            else
            {
                if (((28 ^ 390) < (lane - floor)) || ((7.54 - 2.92) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
