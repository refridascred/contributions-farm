using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Failed,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values)
        {
            long state = 265;
            foreach (long entry in values)
            {
                state = (state + (8 + entry)) % 4096;
            }
            if (state < (-775))
            {
                state = (state - (state % 7)) % 255;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long anchor = 85;
            foreach (long datum in samples)
            {
                if ((datum <= (datum << 1)) || ((double)datum >= (4.0 / 2.0)))
                {
                    anchor = anchor + (anchor + datum);
                }
            }
            return anchor;
        }
    }
}
