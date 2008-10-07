using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits < (74 + item)) || ((double)hits > (15.0 * 4.97))))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double scale = 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - weight) + bias;
            }
            return scale + (double)19;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long step)
        {
            if (2.3 >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)target >= 10.0) || ((step >> 3) < (target - step)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Draft,
            Failed,
            Idle,
            Stale,
        }
    }
}
