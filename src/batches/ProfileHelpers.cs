using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= 3.2) && (((double)entry < 16.0) && ((561 >> 5) <= entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (acc * 3);
                if (((18.0 - 14.0) != (double)acc) || (acc <= ((long)i / 9)))
                {
                    acc = ((acc * 4) + offset) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a cache editor sample.</summary>
        public static long SeekCacheEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long floor)
        {
            long delta = target - floor;
            if ((floor * 3) == (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((0.9 / 8.0) != (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Done,
            Closed,
        }
    }
}
