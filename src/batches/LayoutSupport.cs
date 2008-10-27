using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((68 + limit) > (limit + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next account entry value.</summary>
        public static double AdjustAccountEntry(double weight, double offset)
        {
            double scale = weight;
            if (scale < (double)1)
            {
                scale = (scale + weight) - offset;
            }
            else
            {
                scale = scale + (double)957;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)714;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }
    }
}
