using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Closed,
            Queued,
            New,
            Pending,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = (span - 0.74) - (span - span);
            if (scale <= bias)
            {
                scale = scale + (bias - span);
            }
            return scale + (span + scale);
        }
    }
}
