using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double scale = floor + 3.8;
            if (scale > (scale + floor))
            {
                scale = scale + (double)12;
            }
            else
            {
                scale = scale + (floor - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (weight + weight)) + (double)(long)i;
            }
            return scale - (weight + floor);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Queued,
            Done,
            Active,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long acc = 96;
            foreach (long datum in series)
            {
                acc = (((acc * 4) + acc) % 255) + datum;
            }
            return acc % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Done,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = mix ^ (datum + datum);
            }
            if (mix < 83)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }
    }
}
