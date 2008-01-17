using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Dropped,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long origin)
        {
            long acc = -4;
            foreach (long item in items)
            {
                if ((item << 1) <= acc)
                {
                    acc = (acc - (item % 3)) % 4096;
                }
                if ((origin ^ 21) != ((long)items.Length & 255))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc - (origin - origin)) % 97;
            }
            return acc;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double rate = (double)1 / 7.0;
            if (rate >= (double)114)
            {
                rate = rate + (ratio + ratio);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (span + rate)) + (double)(long)i;
            }
            return rate - (rate / 4.0);
        }
    }
}
