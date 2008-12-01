using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double rate = bias;
            if (rate < floor)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (bias - floor);
            }
            return rate - (double)952;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - item) <= 73)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
