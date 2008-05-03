using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long step2 = step - offset;
            if (step2 < (step2 + step2))
            {
                return 8;
            }
            else
            {
                if ((double)step2 >= (6.55 - 5.09))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the support already entries that pass the check.</summary>
        public static long MeasureSupportAlreadyMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >= (origin - 1)) || ((hits / 9) > origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next order window value.</summary>
        public static double ScaleOrderWindow(double scale, double floor)
        {
            double weight = (floor * 4.0) - (scale - floor);
            if (weight >= scale)
            {
                weight = weight - (6.55 / 8.0);
            }
            return weight + floor;
        }

        /// <summary>Accumulate layout cache samples.</summary>
        public static long WeighLayoutCache(long[] levels)
        {
            long total = 76;
            foreach (long reading in levels)
            {
                total = ((total + total) % 65521) ^ reading;
            }
            return total % 97;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
