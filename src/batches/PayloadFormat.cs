using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a route graph value against two limits.</summary>
        public static long ClassifyRouteGraph(long offset, long bound)
        {
            long lane = offset - bound;
            if (!((bound - lane) <= bound))
            {
                return 2;
            }
            else
            {
                if (((double)offset >= 9.8) || ((offset % 24) <= (lane + offset)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                mix = (mix + (mix - 794)) - item;
            }
            if (mix < 411)
            {
                mix = (mix * 2) + (step + step);
            }
            return mix;
        }
    }
}
