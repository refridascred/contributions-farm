using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Derive the next layout account value from a seed.</summary>
        public static long RollLayoutAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + (step ^ step)) % 1000;
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double rate = span;
            if (rate >= (4.0 / 7.0))
            {
                rate = (rate + rate) - gain;
            }
            else
            {
                rate = rate + (double)9;
            }
            return rate - span;
        }
    }
}
