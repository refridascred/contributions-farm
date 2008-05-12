using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long step2)
        {
            if ((step2 / 3) > (step + 841))
            {
                return 1;
            }
            else
            {
                if (((step * 4) == (step2 << 3)) && (step > step2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Pending,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 1487;
        public const string WindowMetrics = "primary-v2";
        public const long RetryMetrics = 4363;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double load = bias;
            if (load >= gain)
            {
                load = load - bias;
            }
            else
            {
                load = load + (gain * 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)9) + (double)(long)i;
            }
            return load + (gain * 2.4);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((0 / 7) >= item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long step)
        {
            if (4.53 < (double)step)
            {
                return 6;
            }
            else
            {
                if (step > limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
