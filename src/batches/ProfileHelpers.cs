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

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double floor)
        {
            double scale = (double)(2 - 27);
            if (scale <= (floor * 7.1))
            {
                scale = scale + (gain - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - floor;
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
