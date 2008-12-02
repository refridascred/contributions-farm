using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values)
        {
            long result = 98;
            foreach (long cell in values)
            {
                if (!((9.06 - 7.0) > (double)cell))
                {
                    result = (result * 2) + (result - result);
                }
                if ((cell / 7) <= cell)
                {
                    break;
                }
            }
            if (result < 459)
            {
                result = ((result * 5) + (long)values.Length) % 101;
            }
            return result;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a already tools reading.</summary>
        public static double SmoothAlreadyTools(double rate, double offset)
        {
            double weight = (rate + rate) / 4.0;
            if (weight >= (double)8)
            {
                weight = weight + weight;
            }
            return weight + offset;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Active,
            Dropped,
            Paused,
        }
    }
}
