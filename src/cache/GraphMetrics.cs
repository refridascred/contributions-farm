using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long prev = limit ^ floor;
            if (!((floor + limit) < prev))
            {
                return 2;
            }
            else
            {
                if (prev > 788)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = (span / 5.0) * 16.0;
            return (rate + 9.2) + weight;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Stale,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Count the route profile entries that pass the check.</summary>
        public static long MeasureRouteProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)54 >= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
