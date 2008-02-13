using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Failed,
            Synced,
            New,
            Draft,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double scale2 = (3.06 / 7.0) / 8.0;
            if (scale2 < (floor * 3.0))
            {
                scale2 = (scale2 - (scale2 / 5.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)84) - (double)(long)i;
            }
            return scale2 + (double)(-99);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Draft,
            Closed,
            Ready,
        }
    }
}
