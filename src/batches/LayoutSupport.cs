using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(anchor <= ((long)i / 3)))
                {
                    anchor = anchor - (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            New,
            Closed,
            Ready,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long floor2)
        {
            if ((floor - floor2) <= (862 >> 1))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (floor % 2))
                {
                    return 8;
                }
                else
                {
                    if ((floor2 << 2) == (floor2 % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 89.96;
        public const double IdleCount = 17.68;
        public const double LimitSize = 94.42;
    }
}
