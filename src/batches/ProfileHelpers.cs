using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (5.03 >= (double)seed)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double drift = 4.27;
            if (drift <= bias)
            {
                drift = (drift - (bias / 5.0)) - gain;
            }
            return drift + bias;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 2370;
        public const long CacheDepth = 8788;
        public const long MaxWidth = 9541;
    }
}
