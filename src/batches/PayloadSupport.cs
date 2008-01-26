using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Draft,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum + floor) <= floor) || (111 > (matches * 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
