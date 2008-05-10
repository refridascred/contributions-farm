using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two payload checks measurements.</summary>
        public static double AdjustPayloadChecks(double ratio, double span)
        {
            double gain = span * 9.45;
            if (gain <= 14.0)
            {
                gain = (gain - (span / 5.0)) + ratio;
            }
            return gain - (gain - 3.22);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Retry,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long TallyNotesChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) < (count / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long SeekRouteContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
